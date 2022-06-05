
$(function () {
    function BringData(employees) {
        $("#employeeTable").find('tr').remove(); //tabloda tr yi bul sonra temizle
        $.each(employees, function (index, data) { //each => jquery de foreach döngüsü.. her elementin index ve datasını tut..
            $("#employeeTable").append(
                `
<tr>
<td>${data.Title}</td>
<td>${data.FirstName}</td>
<td>${data.LastName}</td>
<td><button class="btn btn-sm btn-danger" value='Delete' id=${data.Id}>Delete</button></td>
<td><button class="btn btn-sm btn-warning" value='Update' id=${data.Id}>Update</button></td>
</tr>
`
            )
        })
    }

    //çalışan silme
    $("#employeeTable").on('click', 'button', function () { // on => id'si => 'employeeTable' içerisinden demek.click => event , button => element / button click olduğunda func devreye girecek.
        var currentValue = $(this).attr('value'); //this tıklanan butonu temsil ediyor.attr => attributlerinden demek 'value' olanı currentValue içerisinde at
        var currentId = $(this).attr('id'); //burada da id'yi currentId içerisinde at.
        var message = confirm('işlem yapmak istediğinize eminmisiniz?') // comfirm => onaylama sorusu çıkarıyor. Devam etmek istediğinize eminisiniz gibi...
        if (currentValue == 'Delete') {
            if (message) { //karar yapısı eğer message true ise cvp evet demek.
                $.ajax({
                    method: 'Delete',
                    url: 'https://localhost:44376/api/employees/' + currentId,
                    success: function (data) {
                        BringData(data)
                    }
                })
            }
            else {
                alert("iptal edildi.")
            }
        }
        else if (currentValue == 'Update') {
            //çalışan güncelleme
            if (message) {
                var title = document.getElementById('employeeTitle').value;
                var firstName = document.getElementById('employeeFirstName').value;
                var lastName = document.getElementById('employeeLastName').value;
                var employee = new Employee(title, firstName, lastName);
                employee.EmployeeID = currentId;
                $.ajax({
                    method: 'Put',
                    url: 'https://localhost:44376/api/employees',
                    data: employee,
                    success: function (data) {
                        BringData(data)
                    }
                })
            }
            else {
                alert("iptal edildi.")
            }
        }
    })
    //çalışan ekleme
    $("#btnAddEmployee").click(function () {
        var title = document.getElementById('employeeTitle').value;
        var firstName = document.getElementById('employeeFirstName').value;
        var lastName = document.getElementById('employeeLastName').value;
        var employee = new Employee(title, firstName, lastName);
        $.ajax({
            method: 'Post',
            url: 'https://localhost:44376/api/employees/PostAddEmployee',
            data: employee,
            success: function (data) {
                BringData(data)
            }
        })
    })
    //Api istek
    $("#getEmployee").click(function () {
        $.ajax({
            method: 'Get',
            url: 'https://localhost:44376/api/employees',
            success: function (data) {
                BringData(data)
            }
        })
    })

})

class Employee {
    EmployeeID;
    Title;
    FirstName;
    LastName;
    constructor(_title, _firstName, _lastName) {
        this.Title = _title;
        this.FirstName = _firstName;
        this.LastName = _lastName;
    }
    //info() {
    //    return this.FirstName + " " + this.LastName; //buna gerek yok deneme amaçlı metot..
    //}
}