$(document).ready(function () {
    $.ajax({
        method: 'Get',
        url: '/api/movies/getmovies'
    }).done(function (movies) {
        for (var i = 0; i < movies.length; i++) {
            var tr = `
<tr class="trMovie">
                    <td>${movies[i].Id}</td>
                    <td>${movies[i].Title}</td>
                    <td>${movies[i].Description}</td>
                    <td>${movies[i].Rate}</td>
                    <td>${movies[i].Year}</td>
</tr>
                    `
            $("#movieTable").append(tr);
        }
    })
    //Rastgele film gelmesi..
    function getRandomMovie() {
        $.ajax({
            method: 'Get',
            url: '/api/movies/GetRandomMovies'
        }).done(function (response) {
            clearTable() //önce tablo temizlensin sonra rastege film gelsin..
            var tr = `
<tr class="trMovie">
                    <td>${response.Id}</td>
                    <td>${response.Title}</td>
                    <td>${response.Description}</td>
                    <td>${response.Rate}</td>
                    <td>${response.Year}</td>
</tr>
                    `
                $("#movieTable").append(tr);
        })
    }

    //GetRandomHighRatingMovie
    function GetRandomHighRatingMovie() {
        $.ajax({
            method: 'Get',
            url: '/api/movies/GetRandomHighRatingMovie'
        }).done(function (movie) {
            clearTable()
            var tr = `
<tr class="trMovie">
<td>${movie.Id}</td>
<td>${movie.Title}</td>
<td>${movie.Description}</td>
<td>${movie.Rate}</td>
<td>${movie.Year}</td>
</tr>
`
            $("#movieTable").append(tr);
        })
    }

    //Search - Film arama
    function Search() {
        var result = document.getElementById('txtAra').value;
        $.ajax({
            method: 'Get',
            url: '/api/movie/'+result
        }).done(function (movies) {
            console.log(movies.count)
            clearTable()
            for (var i = 0; i < movies.length; i++) {
                var tr = `
<tr class="trMovie">
                    <td>${movies[i].Id}</td>
                    <td>${movies[i].Title}</td>
                    <td>${movies[i].Description}</td>
                    <td>${movies[i].Rate}</td>
                    <td>${movies[i].Year}</td>
</tr>
                    `
                $("#movieTable").append(tr);
            }
        })
    }
    //tabloyu temizleme
    function clearTable() {
        $(".trMovie").remove();
    }

    //RandomMovie
    $("#btnRandom").click(function () {
        getRandomMovie()
    })

    //RandomHighRatinMovie
    $("#btnRatingMovie").click(function () {
        GetRandomHighRatingMovie()
    })

    //SearchMovie
    $("#txtAra").keyup(function () {
        Search()
    })
})