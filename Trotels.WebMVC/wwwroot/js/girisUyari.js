// Düğmeye tıklandığında popup açılacak
document.getElementById("openModalButton").addEventListener("click", function () {
    document.getElementById("myModal").style.display = "block";
});

// Popup'ı kapat düğmesine tıklandığında kapat
document.getElementById("closeModal").addEventListener("click", function () {
    document.getElementById("myModal").style.display = "none";