document.getElementById("imagem").addEventListener("change", readImage, false);

// executa quando o botão for clicado
document.getElementById("consultar").addEventListener("click", function (event) {
    // não deixa que o formulário seja enviado
    event.preventDefault();
    // chama a função limpar passando o id consultar
    LimparFormulario(document.getElementById("consultar").id);
    // imprime no console o botão clicado e os dados preenchidos
    ImprimirConsole(document.getElementById("consultar").id);
    // executa a função e verifica se todos os campos necessários foram preenchidos se faltar algum campo saia da função
    if (ValidarConsultarExcluir().length > 0) return;
    // enviar formulário
    SubmeterFormulario("/Produto/Consultar");
});

// executa quando o botão for clicado
document.getElementById("salvar").addEventListener("click", function (event) {
    // não deixa que o formulário seja enviado
    event.preventDefault();
    // chama a função limpar passando o id salvar
    LimparFormulario(document.getElementById("salvar").id);
    // imprime no console o botão clicado e os dados preenchidos
    ImprimirConsole(document.getElementById("salvar").id);
    // executa a função e verifica se todos os campos necessários foram preenchidos se faltar algum campo saia da função
    if (ValidarSalvar().length > 0) return;
    // enviar formulário
    SubmeterFormulario("/Produto/Salvar");
});

// executa quando o botão for clicado
document.getElementById("excluir").addEventListener("click", function (event) {
    // não deixa que o formulário seja enviado
    event.preventDefault();
    // chama a função limpar passando o id excluir
    LimparFormulario(document.getElementById("excluir").id);
    // imprime no console o botão clicado e os dados preenchidos
    ImprimirConsole(document.getElementById("excluir").id);
    // executa a função e verifica se todos os campos necessários foram preenchidos se faltar algum campo saia da função
    if (ValidarConsultarExcluir().length > 0) return;
    // enviar formulário
    SubmeterFormulario("/Produto/Excluir");
});

// executa quando o botão for clicado
document.getElementById("limpar").addEventListener("click", function (event) {
    // não deixa que o formulário seja enviado
    event.preventDefault();
    // chama a função limpar passando o id limpar
    LimparFormulario(document.getElementById("limpar").id);
    // imprime no console o botão clicado e os dados em branco
    ImprimirConsole(document.getElementById("limpar").id);
});

// função usada para fazer uma prévia da imagem do produto
function readImage() {
    if (this.files && this.files[0]) {
        var file = new FileReader
        file.onload = function (e) {
            document.getElementById("imagem_preview").src = e.target.result;
        };
        file.readAsDataURL(this.files[0]);
    }
}
// função usada para limpar dados de acordo com o butão clicado
function LimparFormulario(id) {
    // limpa os dados que não são necessários para o salvar
    if (id == "limpar" || id == "salvar") {
        document.querySelector(".cadastro_campos").querySelectorAll("label")[0].textContent = "Código";
        document.getElementById("codigo").value = "";
    }
    // limpa os dados que não são necessários para os butões consultar e excluir
    if (id == "limpar" || id == "consultar" || id == "excluir") {
        document.querySelector(".cadastro_campos").querySelectorAll("label")[1].textContent = "Produto";
        document.querySelector(".cadastro_campos").querySelectorAll("label")[2].textContent = "Preço";
        document.querySelector(".cadastro_campos").querySelectorAll("label")[3].textContent = "Quantidade";
        document.querySelector(".cadastro_campos").querySelectorAll("label")[4].textContent = "Descrição";
        document.querySelector(".cadastro_campos").querySelectorAll("label")[5].textContent = "Imagem";
        document.getElementById("produto").value = "";
        document.getElementById("preco").value = "";
        document.getElementById("quantidade").value = "";
        document.getElementById("descricao").value = "";
        document.getElementById("imagem").value = "";
        document.getElementById("imagem_preview").src = "";
        return
    }
}

function ImprimirConsole(id) {
    console.clear();
    console.log(document.getElementById(id).id);

    if (id == "consultar" || id == "excluir") {
        console.log("código: " + document.getElementById("codigo").value);
    }
    if (id == "salvar") {
        console.log("produto: " + document.getElementById("produto").value);
        console.log("preço: " + document.getElementById("preco").value);
        console.log("quantidade: " + document.getElementById("quantidade").value);
        console.log("descrição: " + document.getElementById("descricao").value);
        console.log("imagem: " + document.getElementById("imagem").value);
    }
}

function ValidarConsultarExcluir() {
    var label = [];
    if (document.getElementById("codigo").value == "") {
        document.getElementById("codigo").focus();
        label.push(document.querySelector(".cadastro_campos").querySelectorAll("label")[0].textContent = "Código não pode ficar em branco!");
    }
    return label;
}
function ValidarSalvar() {
    var label = [];
    if (document.getElementById("produto").value == "") {
        document.getElementById("produto").focus();
        label.push(document.querySelector(".cadastro_campos").querySelectorAll("label")[1].textContent = "Produto não pode ficar em branco!");
    }
    if (document.getElementById("preco").value == "") {
        document.getElementById("preco").focus();
        label.push(document.querySelector(".cadastro_campos").querySelectorAll("label")[2].textContent = "Preço não pode ficar em branco!");
    }
    if (document.getElementById("quantidade").value == "") {
        document.getElementById("quantidade").focus();
        label.push(document.querySelector(".cadastro_campos").querySelectorAll("label")[3].textContent = "Quantidade não pode ficar em branco!");
    }
    if (document.getElementById("descricao").value == "") {
        document.getElementById("descricao").focus();
        label.push(document.querySelector(".cadastro_campos").querySelectorAll("label")[4].textContent = "Descrição não pode ficar em branco!");
    }
    if (document.getElementById("imagem").value == "") {
        document.getElementById("imagem").focus();
        label.push(document.querySelector(".cadastro_campos").querySelectorAll("label")[5].textContent = "Imagem não pode ficar em vazia!");
    }
    document.querySelector(".cadastro_campos").querySelectorAll("label")[0].textContent = "Código";
    return label;
}

function SubmeterFormulario(controller) {
    document.querySelector(".cadastro_formulario").action = controller;
    document.querySelector(".cadastro_formulario").submit();
}

// função não está sendo usada
function ResetarFormulario() {
    document.querySelector(".cadastro_formulario").reset();
}
