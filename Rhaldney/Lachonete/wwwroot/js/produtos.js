for (var i = 0; i < document.querySelectorAll("#adicionar").length; i++) {
    document.querySelectorAll("#adicionar")[i].addEventListener("click", function (event) {
        var codigo = event.target.value.split("#")[0];
        var produto = event.target.value.split("#")[1];
        var preco = event.target.value.split("#")[2];
        var quantidade = event.target.value.split("#")[3];
        var descricao = event.target.value.split("#")[4];
        var imagem = event.target.value.split("#")[5];

        var request = new XMLHttpRequest();
        request.open("GET", "https://localhost:7256/Produto/Adicionar" + "/" + codigo + "/" + produto + "/" + preco + "/" + quantidade + "/" + descricao + "/" + "null" );
        request.send();
        alert("Adicionado");
    });
}