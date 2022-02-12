const button = document.querySelectorAll("[data-button]");
button.forEach(function (button) {
    button.addEventListener("click", Executar);
});

const input = document.querySelectorAll("[data-input]");
input.forEach(function (input) {
    input.addEventListener("input",Validar);
});

const inputPreview = document.querySelector("[data-input=imagem]");
inputPreview.addEventListener("change", Preview);

function Executar() {
    event.preventDefault();

    switch (event.target.dataset.button) {
        case "Consultar":
        case "Salvar":
            if (Validar()) { SubmeterPost(); }
        break;

        case "Adicionar":
        case "Remover":
            SubmeterGet(event.target.dataset.button,event.target.value);
        break;

        case "Carrinho":

    }
}

function Validar() {
    
    var contador = [];
    var labelValidar;
    var inputValidar;
    var labelLimpar;
    var inputLimpar;

    if (event.target.dataset.button == "Consultar" || event.target.dataset.input == "codigo") {
        labelValidar = document.querySelectorAll("[data-label=codigo]");
        inputValidar = document.querySelectorAll("[data-input=codigo]");
        labelLimpar = document.querySelectorAll("[data-label]:not([data-label=codigo])");
        inputLimpar = document.querySelectorAll("[data-input]:not([data-input=codigo])");
    }
    else if (event.target.dataset.button == "Salvar" || event.target.dataset.input != "codigo") {
        labelValidar = document.querySelectorAll("[data-label]:not([data-label=codigo])");
        inputValidar = document.querySelectorAll("[data-input]:not([data-input=codigo])");
        labelLimpar = document.querySelectorAll("[data-label=codigo]");
        inputLimpar = document.querySelectorAll("[data-input=codigo]");
    }
    
    inputValidar.forEach(function (inputValidar, key) {
        if (inputValidar.value == "") {
            labelValidar[key].textContent = labelValidar[key].textContent.split(" ")[0] + " não pode ser vazio!";
            contador.push(event.target);
        }
        else {
            labelValidar[key].textContent = labelValidar[key].textContent.split(" ")[0];
        }
    });

    inputLimpar.forEach(function (input, key) {
        labelLimpar[key].textContent = labelLimpar[key].textContent.split(" ")[0];
        input.value = "";
    });

    return contador == 0;
}

function SubmeterPost() {
    const form = document.querySelector("[data-form=produto]")
    form.action = "/Produto/" + event.target.dataset.button
    form.submit(); 
}

function SubmeterGet(controller, codigo) {
    console.log(codigo);
    var request = new XMLHttpRequest();
    request.open("GET", document.location.origin + "/Produto/" + controller + "/" + codigo);
    request.send();
}

function Preview() {
    const imgPreview = document.querySelector("[data-img=imagem]");

    if (this.files && this.files[0]) {
        var file = new FileReader
        file.onload = function (event) {
            imgPreview.src = event.target.result;
        };
        file.readAsDataURL(this.files[0]);
    }
}
