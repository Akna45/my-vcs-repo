//ini adalah percobaan javascript
console.log(
    "Halo, ini adalah percobaan Javascript, masukkan command ke console ini :"
);

// awal function
document.getElementById("btn-1").onclick = function () {
    console.log("button 1 ditekan");
};

document.getElementById("btn-2").onclick = function () {
    document.getElementById("text").style.fontSize = "40px";
    console.log("button 2 ditekan, teks akan diperbesar");
};

document.getElementById("btn-3").onclick = function () {
    document.getElementById("heading").remove();
    console.log("button 3 ditekan, teks Heading dihilangkan");
};

document.getElementById("btn-4").onclick = function () {
    console.log("tombol 4 ditekan, akan ada peringatan sebentar lagi");
    alert("Tombol 4 ditekan!!");
};
//akhir function

//pelajaran Javascript