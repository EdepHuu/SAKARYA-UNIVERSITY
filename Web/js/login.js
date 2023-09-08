function validateform() {
    var name = document.myform.name.value;
    var password = document.myform.password.value;

    if (name == null || name == "") {
        alert("Email alanı dolu olmalı");
        return false;
    } else if (password.length < 6) {
        alert("Parola en az 6 haneli olmalı.");
        return false;
    }
}  