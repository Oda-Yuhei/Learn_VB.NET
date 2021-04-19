Public Class GDate
  'chapter4===============================



  Public Property Year() As Integer

  Public Property Month() As Integer

  Public Property Day() As Integer


  Public Sub New(Year As Integer,Month As Integer,Day As Integer)
      MyClass.Year = Year
      MyClass.Month = Month
      MyClass.Day = Day
      xyear = _Year
      xmonth = _Month
      xday = _Day
      ElapsedDay(Year, Month , Day)
  End Sub
  Public Overloads Function ElapsedDay(ByVal Z As Integer)
    Return Z
    
  End Function
    
  'chaputer4================================


  Public Function IsLeapYear(ByVal Year As Integer) As Boolean
      Return Year Mod 400 = 0 Or Year Mod 4 = 0 And Not Year Mod 100 = 0 
  End Function
   
  Public Function IsValidDate(year As Integer, month As Integer, day As Integer) As Boolean
      If year >=  0 And day >= 1
          Select Case month
              Case 2
                  Return If(IsLeapYear(year),29,28) >= day
              Case 4, 6, 9
                  Return day <= 30
              Case 1, 3, 5, 7, 8, 10, 12
                  Return day <= 31
              Case Else
                  Return -1     
          End Select
      Else 
          Return -1
      End If
  End Function

    

  Public Function ElapsedDay(year As Integer, month As Integer, day As Integer) As Integer
      Dim xyear As Integer = 1600
      Dim xmonth As Integer = 1
      Dim xday As Integer = 1
      Dim x As Integer = 0
      Dim y As Integer = 0
      Dim z As Integer = 0

      Dim Ansday As Integer
      Dim Uruu As Integer = 0
      Dim count As Integer = 0


      If IsValidDate(year, month, day) Then
          'year--------------------------------------------
          x = year - xyear
          If IsLeapYear(year) Then
              If month > 2 Then
                  Uruu += 1
              End If
          End If
          For i As Integer = 1600 To year -1
              If IsLeapYear(i)Then
                  Uruu += 1
              End If

                
          Next i
          x = x * 365 + Uruu
            
          'month-----------------------------------------------------

          y = month - xmonth 
          Select Case y
              Case 0
                  y = 0 
              Case 1
                  y = 31
              Case 2
                  y = 59 
              Case 3
                  y = 90 
              Case 4
                  y = 120 
              Case 5
                  y = 151 
              Case 6
                  y = 181
              Case 7
                  y = 212 
              Case 8
                  y = 243
              Case 9
                  y = 273
              Case 10
                  y = 304 
              Case 11
                  y = 334 
          End Select
          'day--------------------------------------------------
          z = day - xday
          Ansday = x + y + z

          return Ansday
      Else
          Return -1
      End If
  End Function
  
End Class
