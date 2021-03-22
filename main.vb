imports System
imports System.Windows.Forms
imports System.Drawing

Module Module1 
    Public Class Form1 : Inherits Form
        Private labelWidth As Integer = 60
        Private labelHeight As Integer = 30
        Private address, district, gender, interest, aboutYou, user_name, readingSelected, travelSelected, cookingSelected, isMale, isFemale, aboutYouDetail, districtSelected As Label
        Private districtNames As Label()
        Private nameTextBox, addressTextBox, aboutYouTextBox as TextBox
        Private readingCheck, travelCheck, cookingCheck as CheckBox
        Private male, female as RadioButton
        Private submit, reset as Button
        Private form2 As Form
        Private listbox As ComboBox
        Private districtNamesList As String()
        Public Sub New()
            Me.Text = "My Form"
            Me.Size = New size(500, 500)
            Me.Name = "Form1"
            Me.Show()
            FormElements()
        End Sub

        Private Sub FormElements()
            user_name = New Label()
            address = New Label()
            district = New Label()
            gender = New Label()
            interest = New Label()
            aboutYou = New Label()
            nameTextBox = New TextBox()
            addressTextBox = New TextBox()
            'districtTextBox = New TextBox()
            'interestTextBox = New TextBox()
            aboutYouTextBox = New TextBox()
            male = New RadioButton()
            female = New RadioButton()
            readingCheck = New CheckBox()
            travelCheck = New CheckBox()
            cookingCheck = New CheckBox()
            submit = New Button()
            reset = New Button()
            listbox = New ComboBox()
            districtNamesList = New String() {"Kathmandu", "Lalitpur", "Bhaktapur", "Pokhara", "Janakpur","Chitwan", "Hetuda", "Dharan"}
            
            user_name.Size = New Size(labelWidth, labelHeight)
            address.Size = New Size(labelWidth, labelHeight)
            district.Size = New Size(labelWidth, labelHeight)
            gender.Size = New Size(labelWidth, labelHeight)
            interest.Size = New Size(labelWidth, labelHeight)
            aboutYou.Size = New Size(labelWidth, labelHeight)
            male.Size = New Size(labelWidth, labelHeight)
            female.Size = New Size(labelWidth, labelHeight)
            listbox.Size = New Size(labelWidth*2, labelHeight)


            nameTextBox.height = 30
            nameTextBox.width = 100
            aboutYouTextBox.MultiLine = true
            aboutYouTextBox.Size = new Size(labelWidth*2, labelHeight*2)
            readingCheck.Size = New Size(labelWidth+20, labelHeight)

            user_name.Text = "Name"
            address.Text = "Address"
            district.Text = "District"
            gender.Text = "Gender"
            interest.Text = "Interest"
            aboutYou.Text = "About You"
            male.Text = "Male"
            female.Text = "Female"
            submit.Text = "Submit"
            reset.Text = "Resrt"
            readingCheck.Text = "Reading"
            travelCheck.Text = "Travelling"
            cookingCheck.Text = "Cooking"

            For Each item In districtNamesList
                listbox.Items.Add(item)
            Next
            

            user_name.Location = New Point(Me.Width/2-labelWidth*2, 20)
            address.Location = New Point(Me.Width/2-labelWidth*2, 60)
            district.Location = New Point(Me.Width/2-labelWidth*2, 100)
            gender.Location = New Point(Me.Width/2-labelWidth*2, 140)
            interest.Location = New Point(Me.Width/2-labelWidth*2, 180)
            aboutYou.Location = New Point(Me.Width/2-labelWidth*2, 220)
            nameTextBox.Location = New Point(Me.Width/2-labelWidth, 20)
            addressTextBox.Location = New Point(Me.Width/2-labelWidth, 60)
            listbox.Location = New Point(Me.Width/2-labelWidth, 100)
            aboutYouTextBox.Location = New Point(Me.Width/2-labelWidth, 220)
            male.Location = New Point(Me.Width/2-labelWidth, 140)
            female.Location = New Point(Me.Width/2+male.size.width/2-15, 140)
            readingCheck.Location = New Point(Me.Width/2-labelWidth, 180)
            travelCheck.Location = New Point(Me.Width/2+readingCheck.size.width/2, 180)
            cookingCheck.Location = New Point(Me.Width/2+readingCheck.size.width+70, 180)
            submit.Location = New Point(Me.Width/2-labelWidth-50, 300)
            reset.Location = New Point(Me.Width/2+labelWidth, 300)


            AddHandler submit.Click, AddressOf submitBtnClick
            AddHandler reset.Click, AddressOf resetBtnClick
            AddHandler readingCheck.CheckStateChanged, AddressOf readingBoxChecked
            AddHandler travelCheck.CheckStateChanged, AddressOf travelBoxChecked
            AddHandler cookingCheck.CheckStateChanged, AddressOf cookingBoxChecked
            AddHandler male.Click, AddressOf maleChecked
            AddHandler female.Click, AddressOf femaleChecked
            AddHandler listbox.SelectedValueChanged, AddressOf listboxValueSelected

            Me.Controls.Add(user_name)
            Me.Controls.Add(address)
            Me.Controls.Add(gender)
            Me.Controls.Add(district)
            Me.Controls.Add(interest)
            Me.Controls.Add(aboutYou)
            Me.Controls.Add(nameTextBox)
            Me.Controls.Add(listbox)
            Me.Controls.Add(addressTextBox)
            Me.Controls.Add(readingCheck)
            Me.Controls.Add(travelCheck)
            Me.Controls.Add(cookingCheck)
            Me.Controls.Add(aboutYouTextBox)
            Me.Controls.Add(male)
            Me.Controls.Add(female)
            Me.Controls.Add(submit)
            Me.Controls.Add(isMale)
            Me.Controls.Add(isFemale)
            Me.Controls.Add(reset)

        End Sub

        Private Sub submitBtnClick(source as Object, e As EventArgs)
            Dim user_info_name As Label
            Dim user_info_address As Label
            form2 = New Form()
            form2.Show()
            
            user_info_name = New Label()
            user_info_name.Location = New Point(50, 20)
            user_info_name.Text = nameTextBox.Text
            user_info_address = New Label()
            user_info_address.Location = New Point(50, 50)
            user_info_address.Text = addressTextBox.Text
            aboutYouDetail = New Label()
            aboutYouDetail.Text = aboutYouTextBox.Text
            aboutYouDetail.Size = new Size(labelWidth*2, labelHeight*2)
            aboutYouDetail.Location = New Point(50, 140)
          

            form2.Controls.Add(user_info_name)
            form2.Controls.Add(user_info_address)
            form2.Controls.Add(readingSelected)
            form2.Controls.Add(travelSelected)
            form2.Controls.Add(cookingSelected)
            form2.Controls.Add(isMale)
            form2.Controls.Add(isFemale)
            form2.Controls.Add(aboutYouDetail)
            form2.Controls.Add(districtSelected)

        End Sub

        Private Sub resetBtnClick(source as Object, e As EventArgs)
            nameTextBox.Text = " "
            addressTextBox.Text = " "
            aboutYouTextBox.Text = " "

        End Sub

        Private Sub readingBoxChecked(source As Object, e As EventArgs)
            readingSelected = New Label()
            readingSelected.Size = New Size(labelWidth, labelHeight)
            readingSelected.Text = readingCheck.Text
            readingSelected.Location = New Point(50,80)            
        End Sub
            
        Private Sub travelBoxChecked(source As Object, e As EventArgs)
            travelSelected = New Label()
            travelSelected.Size = New Size(labelWidth, labelHeight)
            travelSelected.Text = travelCheck.Text
            travelSelected.Location = New Point(120,80)            
        End Sub

        Private Sub cookingBoxChecked(source As Object, e As EventArgs)
            cookingSelected = New Label()
            cookingSelected.Size = New Size(labelWidth, labelHeight)
            cookingSelected.Text = cookingCheck.Text
            cookingSelected.Location = New Point(190,80)            
        End Sub

        Private Sub maleChecked(source As Object, e As EventArgs)
            isMale = New Label()
            isMale.Size = New Size(labelWidth, labelHeight)
            isMale.Text = male.Text
            isMale.Location = New Point(50,110)            
        End Sub

        Private Sub femaleChecked(source As Object, e As EventArgs)
            isFemale = New Label()
            isFemale.Size = New Size(labelWidth, labelHeight)
            isFemale.Text = female.Text
            isFemale.Location = New Point(50,110)            
        End Sub

        Private Sub listboxValueSelected(source As Object, e As EventArgs)
            districtSelected = New Label()
            districtSelected.Text = CStr(listbox.SelectedItem) 
            console.writeline(districtSelected.text)
            districtSelected.Size = New Size(labelWidth, labelHeight)
            districtSelected.Location = New Point(50, 170)
        End Sub

        Public Shared Sub Main(args as [String]())
            Application.Run(new Form1)
        End Sub 
    End Class
End Module