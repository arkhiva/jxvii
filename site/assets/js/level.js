const input = document.querySelector("#code");
const submit = document.querySelector("#submit");
const status = document.querySelector(".level-status");
const popup = document.querySelector("#success-popup");

function normalize(value) {
    return value
        .trim()
        .toUpperCase()
        .replace(/\s+/g, "");
}

function showStatus(type, message) {
    if (!status) {
        return;
    }

    status.className = "level-status";

    if (type) {
        status.classList.add(type);
    }

    status.textContent = message ?? "";
}

function checkCode() {
    // Limpa qualquer mensagem anterior
    showStatus();

    const value = normalize(input.value);

    // Campo vazio
    if (!value) {
        return;
    }

    // Resposta correta
    for (const answer of levelData.answers) {
        if (value === normalize(answer)) {
            openSuccessPopup();
            return;
        }
    }

    // Procura dicas
    for (const hint of levelData.hints) {
        for (const trigger of hint.triggers) {
            if (value === normalize(trigger)) {
                showStatus(hint.type, hint.message);
                return;
            }
        }
    }

    // Nenhuma resposta encontrada
    showStatus("error", "Código incorreto.");
}

function openSuccessPopup() {
    if (!popup) {
        return;
    }

    input.value = "";
    input.disabled = true;
    submit.disabled = true;
    popup.classList.remove("hidden");
    const button = popup.querySelector(".button");

    if (button) {
        button.focus();
    }
}

if (input) {
    input.addEventListener("input", () => {
        if (status.textContent) {
            showStatus();
        }
    });

    input.addEventListener("keydown", event => {
        if (event.key === "Enter") {
            checkCode();
        }
    });
}

if (submit) {
    submit.addEventListener("click", () => {
        checkCode();
    });
}