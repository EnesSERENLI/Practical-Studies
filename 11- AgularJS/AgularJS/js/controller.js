myAngular
    .controller("myController", function ($scope, $location, $http, hex) {
        $scope.firstName = 'Enes';
        $scope.lastName = 'Serenli';
        $scope.fullName = function () { //function oluşturup değişkeneri geri dönebiliriz. Yada ne istersek!
            return $scope.firstName + " " + $scope.lastName;
        }
        $scope.num1 = 10;
        $scope.person = [
            { name: 'Fatih', surname: 'Serenlii', age: 40 },
            { name: 'Enes', surname: 'Fasdjasd', age: 29 }

        ]
        $scope.days = ["Pazartesi", "Salı", "Çarşamba"]
        $scope.eposta = "enes.serenli@hotmail.com"
        $scope.orderMe = function (par) { //orderMe adında bir function oluştur. parametre alsın aldığını writeMe içerisine atsın.
            $scope.writeMe = par;
        }

        $scope.url = $location.absUrl(); // absUrl() metodu url'i verir.

        $scope.GetEmployee = function () {
            $http({
                method: "Get",
                url: "../Home/Employees"
            }).then(function (response) {
                $scope.employees = response.data; //dönen cevap
                $scope.statusCode = response.status; //cevabın durumu
                $scope.statusText = response.statusText; //durumun string karşılığı
            }, function (response) { //Hata durumunda devreye girecek func..
                $scope.employees = response.data.employee;
                $scope.statusCode = response.status;
                if (statusCode == 404) {
                    $scope.statusText = "Not Found";
                }
                else {
                    $scope.statusText = "Bad Request";
                }
            });
        }

        $scope.hexNumber = hex.specialFunction(200);
    })
    .directive("testDirective", function () {
        return {
            restrict: "EA", //A => Attribute E => Element C => Class M => Comment Default => EA (kısıtlamalar)
            replace: true, //visible olsun mu? 
            template: "<h3>AngularJS Directive</h3>"
        };
    })

    .filter("myCustomFilter", function () { //custom bir filtreleme oluşturma..
        return function (par) {
            var i, harf, kelime = "";
            for (var i = 0; i < par.length; i++) {
                harf = par[i];
                if (i % 2 == 0) {
                    harf = harf.toUpperCase();
                }
                kelime += harf;
            }
            return kelime;
        }
    })
    .filter("hexFilter", ["hex", function (hex) {
        return function (x) {
            return hex.specialFunction(x);
        };
    }])
    .service("hex", function () { //cusstom servis oluşturma ve hangi controllerda istersek verebiliriz..
        this.specialFunction = function (par) {
            return par.toString(16);
        }
    });


//ng-repeat="x in days" => ng-repeat döngüdür. foreach gibi..
//ng-model => değişkeni alma ve saklama
//ng-bind => gösterme (InnerHTML a değeri verme)
/*
 <form name="myFrm">
            E-mail = <input type="email" name="myAddress" ng-model="eposta" required />
            <h3 ng-show="myFrm.myAddress.$error.email">Email tipinde bir adres giriniz!</h3> ng-show => true ise göster false ise gösterme
            <h3>Valid: {{myFrm.myAddress.$valid}}</h3> => scoplerin içerisi true yada false döner! valid ise true değilse false
            <h3>Dirty: {{myFrm.myAddress.$dirty}}</h3> => değiştirme yapıldığında true olur 
            <h3>Touched: {{myFrm.myAddress.$touched}}</h3> => olay yerine gelindikten sonra ayrıldığında true olur. Örn. bir input içerisine imleç getirip tekrar çıkarmak gibi.
        </form>

<style>
        input.ng-invalid{
            border: 2px solid red;
        }
        input.ng-valid {
            border: 2px solid green;
        }
        input.ng-empty {
            border: solid;
        }
    </style>
 */

/*
 Filtrelemeler
  kullanımı => {{variable | filtre}}

currency => sayıyı para birimine çevirir
date => Tarihi belirtilen formatta biçimlendirir
json => bir nesneyi json formatına çevirir
limitTo => bir arrayi veya string ifadeyi belirtilen sayıda sınırlandırır. => limitTo:4 => baştan 4 , limitTo:4:1 => baştan 4 ama 0. alma limitTo:-3 sondan 3 gibi.
lowercase => küçük harfler
uppercase => büyük harf yapar
number => sayıyı string e çevirir
orderBy => sıralama
 */