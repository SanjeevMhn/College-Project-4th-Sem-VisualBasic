'program that allows students to enter there info and perfrom various tasks like 
'writing the info into a txt file
'reading the txt file and displaying the info
'update the already entered data

imports System
imports System.Drawing
imports System.Windows.Forms

Module Module1
    Public Class Form1 : Inherits Form
        Private appTitle,menuHeader As Label
        Private menuList, content As Panel 
        Private menuItemNew, menuItemLoad, menuItemUpdate, menuItemCancel As Button

        Public Sub New()
            Me.Size = New Size(800,700)
            Me.Text = "Student Information"
            Me.StartPosition = FormStartPosition.CenterScreen
            Me.AutoSize = False 
            Me.Show()
            AppHeader()
            MenuButtons()
            AppMenu()
            AppContent()
            
        End Sub

        Private Sub AppHeader()
            appTitle = New Label()
            appTitle.Text = "Student Information"
            appTitle.BackColor = Color.Red
            appTitle.TextAlign = ContentAlignment.MiddleCenter
            appTitle.Size = New Size(300, 30)
            appTitle.Location = New Point(Me.Width/2 - appTitle.Width/2, 20)
            appTitle.Font = New Font("Sans Serif", 10)
            appTitle.Show()
            Me.Controls.Add(appTitle)
        End Sub

        Private Sub AppMenu()
            menuList = New Panel()
            menuList.Size = New Size(Me.Width*0.20, Me.Height*0.75)
            menuList.Location = New Point(40, 70)
            menuList.BackColor = Color.Pink
            menuList.Show()
            menuList.Controls.Add(menuItemNew)
            menuList.Controls.Add(menuItemLoad)
            menuList.Controls.Add(menuItemUpdate)
            menuList.Controls.Add(menuItemCancel)
            Me.Controls.Add(menuList)            
        End Sub

        Private Sub AppContent()
            content = New Panel()
            content.Size = New Size(Me.Width*0.65, Me.Height*0.75)
            content.Location = New Point(Me.Width/2 - (content.Width/2*0.7), 70)
            content.BackColor = Color.Yellow
            content.Show()
            Me.Controls.Add(content)
        End Sub
        
        Private Sub MenuButtons()
            menuItemNew = New Button()
            menuItemLoad = New Button()
            menuItemUpdate = New Button()
            menuItemCancel = New Button()

            menuItemNew.Text = "New"
            menuItemLoad.Text = "Load"
            menuItemUpdate.Text = "Update"
            menuItemCancel.Text = "Cancel"

            menuItemNew.TextAlign = ContentAlignment.MiddleCenter
            menuItemLoad.TextAlign = ContentAlignment.MiddleCenter
            menuItemUpdate.TextAlign = ContentAlignment.MiddleCenter
            menuItemCancel.TextAlign = ContentAlignment.MiddleCenter

            menuItemNew.Size = New Size(120, 30)
            menuItemLoad.Size = New Size(120, 30)
            menuItemUpdate.Size = New Size(120, 30)
            menuItemCancel.Size = New Size(120, 30)

            menuItemNew.Location = New Point(20,100)
            menuItemLoad.Location = New Point(20,170)
            menuItemUpdate.Location = New Point(20,240)
            menuItemCancel.Location = New Point(20,310)

            menuItemNew.Show()
            menuItemLoad.Show()
            menuItemUpdate.Show()
            menuItemCancel.Show()

            'menuItemNew.BringToFront()
            ' menuItemLoad.BringToFront()
            ' menuItemUpdate.BringToFront()
            ' menuItemCancel.BringToFront()

            ' Me.Controls.Add(menuItemNew)
            ' Me.Controls.Add(menuItemLoad)
            ' Me.Controls.Add(menuItemUpdate)
            ' Me.Controls.Add(menuItemCancel)
        End Sub

        Public Shared Sub Main(args As [String]())
            'Dim myForm As New Form1()    
            Application.Run(New Form1)
        End Sub
    End Class
End Module