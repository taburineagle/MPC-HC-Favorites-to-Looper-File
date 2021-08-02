Public Class mainWindow
    Private Sub MPC_HC_Radio_Click(sender As Object, e As EventArgs) Handles MPC_HC_Radio.Click
        getFavoritesList("MPC-HC")
    End Sub

    Private Sub MPC_BE_Radio_Click(sender As Object, e As EventArgs) Handles MPC_BE_Radio.Click
        getFavoritesList("MPC-BE")
    End Sub

    Private Sub writeButton_Click(sender As Object, e As EventArgs) Handles writeButton.Click
        ' Do the writing thing here, holmes!
        If MPC_HC_Radio.Checked = True Then
            writeLooperFile("MPC-HC")
        Else
            writeLooperFile("MPC-BE")
        End If
    End Sub

    Private Sub getFavoritesList(playerInUse As String)
        favoritesList.Items.Clear() ' remove the old favorites from the list (if they exist)

        Dim MPC_HC_Favorites_Path As String = "HKEY_CURRENT_USER\SOFTWARE\MPC-HC\MPC-HC\Favorites\Files\"
        Dim MPC_BE_Favorites_Path As String = "HKEY_CURRENT_USER\SOFTWARE\MPC-BE\Favorites2\Files\"

        Dim doneSearching As Boolean = False
        Dim currentValue As String
        Dim currentIteration As Integer = 0

        While doneSearching = False
            If playerInUse = "MPC-HC" Then
                currentValue = My.Computer.Registry.GetValue(MPC_HC_Favorites_Path, "Name" & currentIteration, Nothing)
            ElseIf playerInUse = "MPC-BE" Then
                If currentIteration < 10 Then
                    currentValue = My.Computer.Registry.GetValue(MPC_BE_Favorites_Path, "Fav0" & currentIteration, Nothing)
                Else
                    currentValue = My.Computer.Registry.GetValue(MPC_BE_Favorites_Path, "Fav" & currentIteration, Nothing)
                End If
            End If

            If currentValue <> Nothing Then
                Dim currentFavoriteArray() As String

                ' add the current favorite to the list
                If playerInUse = "MPC-HC" Then
                    currentFavoriteArray = Split(currentValue, ";")
                Else
                    currentFavoriteArray = Split(currentValue, "|")
                End If

                Dim currentFavorite As ListViewItem = returnListViewItem(currentFavoriteArray(0),
                                                                         decodeTimeString(currentFavoriteArray(1)),
                                                                         "N/A",
                                                                         currentFavoriteArray(3))
                favoritesList.Items.Add(currentFavorite)
            Else
                'stop looking for more favorites, we're done
                If currentIteration > 0 Then
                    favCountTF.Text = currentIteration & " favorites found for " & playerInUse
                    writeButton.Enabled = True ' if we found favorites, let Saving happen!
                Else
                    favCountTF.Text = "No favorites found for " & playerInUse
                    writeButton.Enabled = False ' if we found no favorites, then don't allow saving
                End If

                doneSearching = True
            End If

            currentIteration += 1
        End While
    End Sub

    Private Function returnListViewItem(ByVal favName As String, ByVal favStart As String, ByVal favRel As String, ByVal favPath As String) As ListViewItem
        Dim newItemArray(4) As String

        newItemArray(0) = favName
        newItemArray(1) = favStart
        newItemArray(2) = favRel
        newItemArray(3) = favPath

        Dim newFavorite As New ListViewItem(newItemArray)
        Return newFavorite
    End Function

    Private Function decodeTimeString(timeString As String) As String
        Dim Byte1, Byte2, Byte3, Byte4 As Integer
        Dim returnString As String

        Byte1 = Int(timeString / 10000000 / 60 / 60) ' the hour indicator
        Byte2 = Int(timeString / 10000000 / 60) Mod 60 ' the minute indicator
        Byte3 = Int(timeString / 10000000) Mod 60 ' the second indicator
        Byte4 = (Int(timeString / 10000) Mod 1000) * 60 / 1000 ' the frame indicator

        returnString = Nothing ' initialize the return string

        If Byte1 > 0 Then ' if byte 1 has an hour value, then add that to the timestamp
            returnString = Byte1 & ":"
        End If

        If Byte2 > 0 Then ' if byte 2 has a minute value, then add that to the timestamp
            If Byte2 < 10 Then ' if it's less than 10, then add a zero to the number
                returnString &= "0" & Byte2 & ":"
            Else
                returnString &= Byte2 & ":"
            End If
        End If

        If Byte3 < 10 Then ' if the second value is less than 10, then add a zero to the number
            returnString &= "0" & Byte3 & "."
        Else
            returnString &= Byte3 & "."
        End If

        returnString &= Byte4 ' add the frame value to the end

        Return returnString
    End Function

    Private Sub writeLooperFile(playerInUse As String)
        Dim saveFileDialog As New SaveFileDialog With {
            .Title = "Save " & playerInUse & " Favorites to .looper File",
            .AddExtension = True,
            .DefaultExt = ".looper",
            .OverwritePrompt = True,
            .Filter = "Looper Files|*.looper",
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop,
            .FileName = playerInUse & "_Favorites"
         }

        If saveFileDialog.ShowDialog(Me) = DialogResult.OK Then
            saveFileDialog.Dispose()
            ' save the .looper file

            Dim writingString As String = Nothing

            For a As Integer = 0 To favoritesList.Items.Count - 1
                writingString &= favoritesList.Items(a).SubItems(0).Text & "|" & favoritesList.Items(a).SubItems(1).Text & "|" & "12:34:56.78" & "|" & favoritesList.Items(a).SubItems(3).Text & vbCrLf
            Next

            System.IO.File.WriteAllText(saveFileDialog.FileName, writingString)
        Else
            saveFileDialog.Dispose()
            ' Don't do any saving
        End If
    End Sub
End Class