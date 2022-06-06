Module moneda
    Public Function transform(variable As String) As String
        Dim resta As Integer
        Dim part1 As String
        Dim part2 As String
        Dim part3 As String
        Dim aux As Integer
        Dim decimales As String


        If variable.Contains(".") Then
            aux = InStr(variable, ".")
            decimales = Mid(variable, aux)
            variable = variable.Remove(aux - 1)


            If variable.Length = 0 Then
            Else
                resta = 9 - variable.Length
                If resta >= 1 Then
                    variable = "0" & variable
                End If
                If resta >= 2 Then
                    variable = "0" & variable
                End If
                If resta >= 3 Then
                    variable = "0" & variable
                End If
                If resta >= 4 Then
                    variable = "0" & variable
                End If
                If resta >= 5 Then
                    variable = "0" & variable
                End If
                If resta >= 6 Then
                    variable = "0" & variable
                End If
                If resta >= 7 Then
                    variable = "0" & variable
                End If
                If resta >= 8 Then
                    variable = "0" & variable
                End If
                part1 = Mid(variable, 1, 3)
                part2 = Mid(variable, 4, 3)
                part3 = Mid(variable, 7, 3)
                variable = part1 & "," & part2 & "," & part3
                If Mid(variable, 1, 1) = "0" Then
                    variable = variable.Remove(0, 1)
                    If Mid(variable, 1, 1) = "0" Then
                        variable = variable.Remove(0, 1)
                        If Mid(variable, 1, 1) = "0" Then
                            variable = variable.Remove(0, 1)
                            If Mid(variable, 1, 1) = "," Then
                                variable = variable.Remove(0, 1)
                                If Mid(variable, 1, 1) = "0" Then
                                    variable = variable.Remove(0, 1)
                                    If Mid(variable, 1, 1) = "0" Then
                                        variable = variable.Remove(0, 1)
                                        If Mid(variable, 1, 1) = "0" Then
                                            variable = variable.Remove(0, 1)
                                            If Mid(variable, 1, 1) = "," Then
                                                variable = variable.Remove(0, 1)
                                                If Mid(variable, 1, 1) = "0" Then
                                                    variable = variable.Remove(0, 1)
                                                    If Mid(variable, 1, 1) = "0" Then
                                                        variable = variable.Remove(0, 1)
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
            variable = "$" & variable & decimales
            Return variable
        Else
            If variable.Length = 0 Then
            Else
                resta = 9 - variable.Length
                If resta >= 1 Then
                    variable = "0" & variable
                End If
                If resta >= 2 Then
                    variable = "0" & variable
                End If
                If resta >= 3 Then
                    variable = "0" & variable
                End If
                If resta >= 4 Then
                    variable = "0" & variable
                End If
                If resta >= 5 Then
                    variable = "0" & variable
                End If
                If resta >= 6 Then
                    variable = "0" & variable
                End If
                If resta >= 7 Then
                    variable = "0" & variable
                End If
                If resta >= 8 Then
                    variable = "0" & variable
                End If
                part1 = Mid(variable, 1, 3)
                part2 = Mid(variable, 4, 3)
                part3 = Mid(variable, 7, 3)
                variable = part1 & "," & part2 & "," & part3
                If Mid(variable, 1, 1) = "0" Then
                    variable = variable.Remove(0, 1)
                    If Mid(variable, 1, 1) = "0" Then
                        variable = variable.Remove(0, 1)
                        If Mid(variable, 1, 1) = "0" Then
                            variable = variable.Remove(0, 1)
                            If Mid(variable, 1, 1) = "," Then
                                variable = variable.Remove(0, 1)
                                If Mid(variable, 1, 1) = "0" Then
                                    variable = variable.Remove(0, 1)
                                    If Mid(variable, 1, 1) = "0" Then
                                        variable = variable.Remove(0, 1)
                                        If Mid(variable, 1, 1) = "0" Then
                                            variable = variable.Remove(0, 1)
                                            If Mid(variable, 1, 1) = "," Then
                                                variable = variable.Remove(0, 1)
                                                If Mid(variable, 1, 1) = "0" Then
                                                    variable = variable.Remove(0, 1)
                                                    If Mid(variable, 1, 1) = "0" Then
                                                        variable = variable.Remove(0, 1)
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
            variable = "$" & variable
            Return variable
        End If

    End Function
End Module
