@Code
Dim db = Database.Open("Bakery")
Dim query = "SELECT * FROM Products" 
End Code
<html> 
    <body> 
        <h1>Listado de autos en alquiler</h1> 
        <table border="1" width="100%"> 
            <tr>
                <th>Id</th> 
                <th>Product</th> 
                <th>Description</th> 
                <th>Price</th> 
            </tr>
            @Code 
            Dim row 
            for each row in db.Query(query)
            End Code
            <tr> 
                <td>@row.Id</td> 
                <td>@row.Name</td> 
                <td>@row.Description</td> 
                <td align="right">@row.Price</td> 
            </tr> 
            @Code next End Code
        </table> 
    </body> 
</html>
