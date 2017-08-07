Imports System.Data.SqlClient

Imports System.Net.Mail


Public Class Form1
    Public connection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & My.Application.Info.DirectoryPath & "\CustomerDatabase.mdf;Integrated Security=True")
    Public con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\viggy\documents\visual studio 2015\Projects\TeamD_Kudler_Application\TeamD_Kudler_Application\CustomerDatabase.mdf;Integrated Security=True")
    Public command As New SqlCommand
    Public id As Integer
    Public firstName As String
    Public lastName As String
    Public phone As String
    Public address As String
    Public city As String
    Public state As String
    Public zipCode As Integer
    Public email As String
    Public numOfVisits As Integer
    Public amountSpent As Double
    Public loyaltyStage As Integer
    Public loyaltyDiscount As String

    Private Sub customerLoyalty()
        Try

            If IsNumeric(txtAmountSpent.Text) Then
                amountSpent = Double.Parse(txtAmountSpent.Text)
                If amountSpent <= 0 Or txtAmountSpent.Text.Equals("") Then
                    labelLoyalty.Visible = False
                End If
                If amountSpent > 0 And amountSpent < 500 Then
                    labelLoyalty.Visible = True
                    labelLoyalty.Text = "Customer will receive 5% off of the total" & Environment.NewLine & "purchase price for joining the rewards program" & Environment.NewLine & "Customer is at stage 1 out of 5 of the rewards program"
                    txtLoyaltyStage.Text = 1
                    txtLoyaltyDiscount.Text = "5%"
                    btnSendEmail.Visible = True
                Else
                    labelLoyalty.Visible = False

                End If
                If amountSpent >= 500 And amountSpent < 1000 Then
                    labelLoyalty.Visible = True
                    labelLoyalty.Text = "Customer will receive 10% off the total" & Environment.NewLine & "purchase price for continuing to be a loyal customer" & Environment.NewLine & "Customer is at stage 2 out of 5 of the rewards program"
                    txtLoyaltyStage.Text = 2
                    txtLoyaltyDiscount.Text = "10%"
                    btnSendEmail.Visible = True
                End If
                If amountSpent >= 1000 And amountSpent < 1500 Then
                    labelLoyalty.Visible = True
                    labelLoyalty.Text = "Customer will receive 15% off the total" & Environment.NewLine & "purchase price for continuing to be a loyal customer" & Environment.NewLine & "Customer is at stage 3 out of 5 of the rewards program"

                    txtLoyaltyStage.Text = 3
                    txtLoyaltyDiscount.Text = "15%"
                    btnSendEmail.Visible = True

                End If
                If amountSpent >= 1500 And amountSpent < 2000 Then
                    labelLoyalty.Visible = True


                    labelLoyalty.Text = "Customer will receive 20% off the total" & Environment.NewLine & "purchase price for continuing to be a loyal customer" & Environment.NewLine & "Customer is at stage 4 out of 5 of the rewards program"

                    txtLoyaltyStage.Text = 4
                    txtLoyaltyDiscount.Text = "20%"
                    btnSendEmail.Visible = False

                End If
                If amountSpent >= 2000 Then
                    labelLoyalty.Visible = True
                    labelLoyalty.Text = "Custommer is considered a great and loyal customer and is rewarded" & Environment.NewLine & "the 25% maximum off of the total purchase price each time they shop" & Environment.NewLine & "Customer is at stage 5 of the rewards program"
                    txtLoyaltyStage.Text = 5
                    txtLoyaltyDiscount.Text = "25%"
                    btnSendEmail.Visible = False
                End If
            End If
            If Not IsNumeric(txtAmountSpent.Text) Then
                MessageBox.Show("Amount Spent must be numeric")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Dim connection As New SqlConnection
        ' Dim command As New SqlCommand
        '  connection.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=c:\users\viggy\documents\visual studio 2015\Projects\TeamD_Kudler_Application\TeamD_Kudler_Application\CustomerDatabase.mdf;Integrated Security=True"


        Try










            'TODO: This line of code loads data into the 'CustomerDatabaseDataSet.Customers' table. You can move, or remove it, as needed.
            Me.TableAdapterManager.CustomersTableAdapter.Fill(Me.CustomerDatabaseDataSet.Customers)
            ProgressBar1.Visible = False
            customerLoyalty()

            ' CustomersBindingSource.DataSource = CustomersTableAdapter.GetData
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Try


            CustomersBindingSource.AddNew()
            txtFirstName.Clear()
            txtLastName.Clear()
            txtPhoneNumber.Clear()
            txtAddress.Clear()
            txtCity.Clear()
            txtState.SelectedIndex = 0
            txtZipCode.Clear()
            txtEmail.Clear()
            txtNumOfVisits.Clear()
            txtLoyaltyStage.Clear()
            txtLoyaltyDiscount.Clear()
            txtAmountSpent.Clear()

            'Me.Validate()
            '  Me.CustomersBindingSource.EndEdit()
            ' Me.TableAdapterManager.UpdateAll(Me.CustomerDatabaseDataSet)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub











    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click


        'Dim cmd As New SqlCommand




        Try
            If txtId.Text <> "" And txtFirstName.Text <> "" And txtLastName.Text <> "" And txtPhoneNumber.Text <> "" And txtAddress.Text <> "" And txtCity.Text <> "" And txtState.Text <> "" And txtZipCode.Text <> "" And txtEmail.Text <> "" And txtNumOfVisits.Text <> "" And txtAmountSpent.Text <> "" And txtLoyaltyStage.Text <> "" And txtLoyaltyDiscount.Text <> "" Then

                If IsNumeric(txtId.Text) And IsNumeric(txtZipCode.Text) And IsNumeric(txtAmountSpent.Text) And IsNumeric(txtNumOfVisits.Text) And IsNumeric(txtLoyaltyStage.Text) And Not txtState.Text = "N/A" Then
                    id = Integer.Parse(txtId.Text)
                    zipCode = Integer.Parse(txtZipCode.Text)
                    amountSpent = Double.Parse(txtAmountSpent.Text)
                    numOfVisits = Integer.Parse(txtNumOfVisits.Text)
                    loyaltyStage = Integer.Parse(txtLoyaltyStage.Text)
                    firstName = txtFirstName.Text
                    lastName = txtLastName.Text
                    address = txtAddress.Text
                    phone = txtPhoneNumber.Text
                    city = txtCity.Text
                    state = txtState.Text
                    email = txtEmail.Text
                    loyaltyDiscount = txtLoyaltyDiscount.Text
                    '  Dim cmd As New SqlCommand(("INSERT INTO [dbo].[Customers] (Id, First_Name, Last_Name, Phone_Number, Address, City, State, Zip_Code, Email, Num_Of_Visits, Amount_Spent, Loyalty_Stage, Loyalty_Discount) VALUES (" & id & ", '" & firstName & "', '" & lastName & "', '" & phone & "', '" & address & "', '" & city & "', '" & state & "', " & zipCode & ", '" & email & "', " & numbOfVisits & ", " & amountSpent & ", " & loyaltyStage & ", '" & loyaltyDiscount & "')"))
                    con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\viggy\documents\visual studio 2015\Projects\TeamD_Kudler_Application\TeamD_Kudler_Application\CustomerDatabase.mdf;Integrated Security=True")
                    Command = New SqlCommand()
                    Command.Connection = con
                    con.Open()

                    command.CommandText = "INSERT INTO [dbo].[Customers] (Id, First_Name, Last_Name, Phone_Number, Address, City, State, Zip_Code, Email, Num_Of_Visits, Amount_Spent, Loyalty_Stage, Loyalty_Discount) VALUES (" & id & ", '" & firstName & "', '" & lastName & "', '" & phone & "', '" & address & "', '" & city & "', '" & state & "', " & zipCode & ", '" & email & "', " & numOfVisits & ", " & amountSpent & ", " & loyaltyStage & ", '" & loyaltyDiscount & "')"
                    command.ExecuteNonQuery()
                    MessageBox.Show("Customer was added successfully")
                    con.Dispose()

                    con.Close()


                    Me.Validate()
                    Me.CustomersBindingSource.EndEdit()
                    Me.TableAdapterManager.UpdateAll(Me.CustomerDatabaseDataSet)
                    ' CustomersBindingSource.EndEdit()
                    CustomersTableAdapter.Update(CustomerDatabaseDataSet)
                    Me.CustomersTableAdapter.Fill(Me.CustomerDatabaseDataSet.Customers)
                Else
                    MessageBox.Show("Zip Code, Amount spent, and Num Of Visits must be numeric. A state must be selected.")
                End If




            Else
                labelError.Text = "Complete all fields before adding to the database"
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
            If con.State = ConnectionState.Open Then
                con.Close()

            End If
        End Try
    End Sub



    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        '  Dim cmd As SqlCommand

        Try
            id = Integer.Parse(txtId.Text)
            con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\viggy\documents\visual studio 2015\Projects\TeamD_Kudler_Application\TeamD_Kudler_Application\CustomerDatabase.mdf;Integrated Security=True")
            Command = New SqlCommand()
            Command.Connection = con
            con.Open()

            command.CommandText = "DELETE FROM [dbo].[Customers] WHERE Id = (" & id & ")"
            command.ExecuteNonQuery()
            TableAdapterManager.CustomersTableAdapter.GetData()
            con.Dispose()

            con.Close()



            MessageBox.Show("Customer removed")
            Me.Validate()
            Me.CustomersBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.CustomerDatabaseDataSet)
            '  Me.TableAdapterManager.CustomersTableAdapter.Fill(Me.CustomerDatabaseDataSet.Customers)
            Me.CustomersTableAdapter.Fill(Me.CustomerDatabaseDataSet.Customers)

            'CustomersDataGridView1.Update()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            If con.State = ConnectionState.Open Then
                con.Close()

            End If
        End Try

    End Sub


    Private Sub btnSendEmail_Click(sender As Object, e As EventArgs) Handles btnSendEmail.Click
        Try
            If txtEmail.Text <> "" And txtFirstName.Text <> "" And txtEmail.Text.Contains("@") And txtEmail.Text.Contains(".com") Then
                ProgressBar1.Visible = True
                Timer1.Start()



                Dim client As New SmtpClient
                Dim mail As New MailMessage
                Dim server As New SmtpClient

                server.Credentials = New Net.NetworkCredential("teamkudler@gmail.com", "teamdkudler")
                server.Port = 587
                server.Host = "smtp.gmail.com"
                server.EnableSsl = True

                mail.To.Add(txtEmail.Text)
                mail.From = New MailAddress("teamdkudler@gmail.com")
                mail.Subject = "Test"

                mail.Body = "Thank you " & txtFirstName.Text & " for shopping with Kudler Fine Foods. Please take some time to look at all the products we offer and enjoy 10% off your next puchase. Use code 1234 at checkout. Thanks for being a valued customer at Kudler Fine Foods and Have a Great day!"

                server.Send(mail)



            Else
                MessageBox.Show("Please make sure there is a name and email entered." & Environment.NewLine & "Email must be in a valid format.")
                ProgressBar1.Visible = False
            End If



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(2000)
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            MessageBox.Show("Your message was sent")
            ProgressBar1.Visible = False
            ProgressBar1.Value = 0

        End If
    End Sub







    Private Sub txtId_TextChanged_1(sender As Object, e As EventArgs) Handles txtId.TextChanged

        Try
            If IsNumeric(txtId.Text) Then
                id = Integer.Parse(txtId.Text)

            Else
                labelError.Text = "Id is invalid, Must be numeric"
                labelError.Visible = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub txtFirstName_TextChanged_1(sender As Object, e As EventArgs) Handles txtFirstName.TextChanged
        Try
            If IsNumeric(txtFirstName.Text) Then
                labelError.Visible = True
                labelError.Text = "Please enter a valid First Name"
                txtFirstName.Text = ""

            End If
            If Not IsNumeric(txtFirstName.Text) Then
                labelError.Visible = False

            End If
            If Not txtFirstName.Text <> "" Then
                labelError.Visible = True
                labelError.Text = "Please enter a valid First Name"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtLastName_TextChanged_1(sender As Object, e As EventArgs) Handles txtLastName.TextChanged
        Try
            If IsNumeric(txtLastName.Text) Then
                labelError.Visible = True
                labelError.Text = "Please enter a valid Last Name"
                txtLastName.Text = ""

            End If
            If Not IsNumeric(txtLastName.Text) Then
                labelError.Visible = False
            End If
            If Not txtLastName.Text <> "" Then
                labelError.Visible = True
                labelError.Text = "Please enter a valid Last Name"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtPhoneNumber_MaskInputRejected_1(sender As Object, e As MaskInputRejectedEventArgs) Handles txtPhoneNumber.MaskInputRejected
        Try

            phone = txtPhoneNumber.Text
            If txtPhoneNumber.Text.Contains("_") Then

                labelError.Text = "Please enter a valid Phone Number, must be 10 digits"
                labelError.Visible = True
            Else
                labelError.Visible = False

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    Private Sub txtCity_TextChanged_1(sender As Object, e As EventArgs) Handles txtCity.TextChanged
        Try
            If IsNumeric(txtCity.Text) Then
                labelError.Visible = True
                labelError.Text = "Invalid City, City cannot be numeric"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtZipCode_MaskInputRejected_1(sender As Object, e As MaskInputRejectedEventArgs) Handles txtZipCode.MaskInputRejected
        Try
            If IsNumeric(txtZipCode.Text) Then
                zipCode = Integer.Parse(txtZipCode.Text)
                If zipCode < 10000 Or zipCode > 99999 Or txtZipCode.Text.Contains("#") Then

                    labelError.Text = "Please enter a valid Zip Code. Zip Code must be 5 digits"
                    labelError.Visible = True
                Else
                    zipCode = Integer.Parse(txtZipCode.Text)
                    labelError.Visible = False
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        Try
            If txtEmail.Text.Contains("@") And txtEmail.Text.Contains(".com") Then
                labelError.Visible = False
            Else
                labelError.Visible = True
                labelError.Text = "Please enter a valid email"


            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub txtNumOfVisits_TextChanged_1(sender As Object, e As EventArgs) Handles txtNumOfVisits.TextChanged
        Try

            If IsNumeric(txtNumOfVisits.Text) Then
                id = Integer.Parse(txtNumOfVisits.Text)
                labelError.Visible = False
                '    Dim numOfVisits As Integer
                ' numOfVisits = Integer.Parse(txtNumOfVisits.Text)


            End If


            If Not IsNumeric(txtNumOfVisits.Text) Then
                labelError.Visible = True
                labelError.Text = "Please enter a numeric value for Number of Visits"
                txtNumOfVisits.Text = ""

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtAmountSpent_TextChanged_1(sender As Object, e As EventArgs) Handles txtAmountSpent.TextChanged
        Try


            If IsNumeric(txtAmountSpent.Text) Then
                amountSpent = Double.Parse(txtAmountSpent.Text)
                ' Double.Parse(amountspent)
                labelError.Visible = False
                '  Dim amountSpent As Double
                '   amountSpent = Double.Parse(txtAmountSpent.Text)

                If IsNumeric(txtId.Text) Then
                    id = Integer.Parse(txtId.Text)
                    If id > 0 Then
                        ' Double.Parse(txtAmountSpent.Text)
                        customerLoyalty()

                    End If
                End If


            End If

            ' If txtId.Text = "" Then
            'MessageBox.Show("Please select Add above the table to insert the Custoemr Id")
            '   End If
            If Not IsNumeric(txtAmountSpent.Text) Or txtAmountSpent.Text = "" Or amountSpent <= 0 Then
                labelError.Visible = True
                labelError.Text = "Please enter a valid numeric value for amount spent"
                txtAmountSpent.Text = ""
                labelLoyalty.Visible = False







            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtLoyaltyStage_TextChanged_1(sender As Object, e As EventArgs) Handles txtLoyaltyStage.TextChanged
        Try
            If IsNumeric(txtLoyaltyStage.Text) Then
                id = Integer.Parse(txtLoyaltyStage.Text)
            Else
                labelError.Visible = True
                labelError.Text = "Loyalty stage must be numeric"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtState_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtState.SelectedIndexChanged
        If txtState.Text = "N/A" Then
            labelError.Visible = True
            labelError.Text = "Please select a state"
        Else
            labelError.Visible = False

        End If
    End Sub

    Private Sub CustomersDataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CustomersDataGridView1.CellContentClick
        Me.Validate()
        Me.CustomersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CustomerDatabaseDataSet)
        Me.CustomersTableAdapter.Fill(Me.CustomerDatabaseDataSet.Customers)
    End Sub
End Class
