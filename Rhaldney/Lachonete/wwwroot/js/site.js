// executa quando o botão for clicado
document.getElementById("consultar").addEventListener("click", function (event) {
    // não deixa que o formulário seja enviado
    event.preventDefault();
    // chama a função limpar passando o id consultar
    LimparFormulario(document.getElementById("consultar").id);
    // executa a função e verifica se todos os campos necessários foram preenchidos se faltar algum campo saia da função
    if (ValidarConsultarExcluir().length > 0) return;
    // imprime no console o botão clicado e os dados preenchidos
    ImprimirConsole(document.getElementById("consultar").id);
    //limpar formulário
    ResetarFormulario();
});

// executa quando o botão for clicado
document.getElementById("salvar").addEventListener("click", function (event) {
    // não deixa que o formulário seja enviado
    event.preventDefault();
     // chama a função limpar passando o id salvar
    LimparFormulario(document.getElementById("salvar").id);
    // executa a função e verifica se todos os campos necessários foram preenchidos se faltar algum campo saia da função
    if (ValidarSalvar().length > 0) return;
    // imprime no console o botão clicado e os dados preenchidos
    ImprimirConsole(document.getElementById("salvar").id);
    //limpar formulário
    ResetarFormulario();
});

// executa quando o botão for clicado
document.getElementById("excluir").addEventListener("click", function (event) {
    // não deixa que o formulário seja enviado
    event.preventDefault();
      // chama a função limpar passando o id excluir
    LimparFormulario(document.getElementById("excluir").id);
    // executa a função e verifica se todos os campos necessários foram preenchidos se faltar algum campo saia da função
    if (ValidarConsultarExcluir().length > 0) return;
    // imprime no console o botão clicado e os dados preenchidos
    ImprimirConsole(document.getElementById("excluir").id);
    //limpar formulário
    ResetarFormulario();
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

function LimparFormulario(id) {
    if (id == "limpar" || id == "salvar") {
        document.querySelector(".cadastro_campos").querySelectorAll("label")[0].textContent = "Código";
        document.getElementById("codigo").value = "";
    }

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
        return
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

function ImprimirConsole(id) {
    console.log(document.getElementById(id).id);

    if (id == "consultar" || id == "excluir") {
        console.log(document.getElementById("codigo").value);
    }
    if (id == "salvar") {
        console.log(document.getElementById("produto").value);
        console.log(document.getElementById("preco").value);
        console.log(document.getElementById("quantidade").value);
        console.log(document.getElementById("descricao").value);
        console.log(document.getElementById("imagem").value);
    }
}

function ResetarFormulario() {
    document.querySelector(".cadastro_formulario").reset();
}