var searchInput = () => {
    const searchBarText = document.getElementById("search-bar").value;
    console.log(searchBarText);

    $.ajax({
        url: "https://localhost:7269/Home/SearchNode",
        method: "GET",
        data: { letter: searchBarText },
        success: function (result) {
            $(".search-results").empty();
            $(".search-results").append(result);
        }
    });
}
