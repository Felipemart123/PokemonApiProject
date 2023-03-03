
    const password = document.getElementById("psw");
    const repeatPassword = document.getElementById("psw-repeat");
    const form = document.querySelector("form");

    form.addEventListener("submit", function(event) {
        const passwordValue = password.value;
        const repeatPasswordValue = repeatPassword.value;

        if (passwordValue !== repeatPasswordValue) {
        event.preventDefault();
            const error = document.createElement("div");
            error.classList.add("error");
            error.textContent = "Passwords do not match.";
            form.insertBefore(error, form.firstChild);
        } else if (passwordValue.length > 10) {
        event.preventDefault();
            const error = document.createElement("div");
            error.classList.add("error");
            error.textContent = "Password cannot be more than 10 characters long.";
            form.insertBefore(error, form.firstChild);
        }
    });

    password.addEventListener("input", function() {
        const error = document.querySelector(".error");
        if (error) {
        form.removeChild(error);
        }
    });

