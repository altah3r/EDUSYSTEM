﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure

Partial Public Class ContextEDU
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=ContextEDU")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub

    Public Overridable Property Answers() As DbSet(Of Answer)
    Public Overridable Property Classes() As DbSet(Of [Class])
    Public Overridable Property Lessons() As DbSet(Of Lesson)
    Public Overridable Property Questions() As DbSet(Of Question)
    Public Overridable Property Students() As DbSet(Of Student)
    Public Overridable Property Subjects() As DbSet(Of Subject)
    Public Overridable Property sysdiagrams() As DbSet(Of sysdiagram)
    Public Overridable Property Users() As DbSet(Of User)
    Public Overridable Property Years() As DbSet(Of Year)

End Class
