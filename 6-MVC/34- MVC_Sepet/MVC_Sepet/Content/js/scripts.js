/*!
* Start Bootstrap - Shop Homepage v5.0.5 (https://startbootstrap.com/template/shop-homepage)
* Copyright 2013-2022 Start Bootstrap
* Licensed under MIT (https://github.com/StartBootstrap/startbootstrap-shop-homepage/blob/master/LICENSE)
*/
// This file is intentionally blank
// Use this file to add JavaScript to your project
<script>
    document.getElementById("decrease").onclick = function () {
            var sayi = document.getElementById("Quantity").value;
    var intSayi = parseInt(sayi);
    intSayi -= 1;
    document.getElementById("Quantity").innerHTML = intSayi;
        }
    document.getElementById("decrease").onclick = function () {
            var sayi = document.getElementById("Quantity").value;
    var intSayi = parseInt(sayi);
    intSayi = intSayi + 1;
    document.getElementById("Quantity").innerHTML = intSayi;
        }
</script>