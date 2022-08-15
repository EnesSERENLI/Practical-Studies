window.onload = function () {
    document.getElementById("print").onclick = function () {
        var result = confirm("Çıktı almak istiyormusunuz ?")
        if (result == true) {
            print()
        }
        else {
            alert("işlem iptal edildi!")
        }
    }    
}
