class circle
  Public Dim r,c As Integer
  function input()
    r=console.readline()
  End function
  function add()
    c=3.14*r*r 
    Return 0
    End Function
    
  Function display()
    console.WriteLine("sum is :")
    console.WriteLine(c)
  End Function
end class

module ma
sub main
  Dim obj As new circle()
  obj.input()
  obj.add()
  obj.display()
end sub
end module
  
