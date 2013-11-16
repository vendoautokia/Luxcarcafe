<!DOCTYPE html>
<html> 
    <body> 
@if (IsPost)
    Dim companyname = Request("CompanyName")
    Dim contactname = Request("ContactName")

    @<p>You entered: <br><br>Company Name: @companyname <br> Contact Name: @contactname </p>
else
    @<form method="post" action=""> Company Name:<br><input type="text" name="CompanyName" value=""><br>Contact Name:<br><input type="text" name="ContactName" value=""><br><br><input type="submit" value="Submit" class="submit"></form>
end if


