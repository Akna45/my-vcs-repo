function Halo(nama,umur) {
    console.log("halo, "+ nama+", Umurmu pasti masih "+ umur +" 'kan?");
}

/*var keluar = confirm("apa anda yakin ingin keluar?")
if(keluar==true){
    alert("baiklah, selamat tinggal :)");
}
else{
    alert("alhamdulillah, masih mau menetap ya...")
}*/
//tempat membuat object
function obyek(nama,umur,alamat){
    this.nama=nama;
    this.umur=umur;
    this.alamat=alamat;
    this.gantiNama=function(nama){
        this.nama=nama;
    }
}
function Siswa(nama,umur,kelas) {
    this.nama=nama;
    this.umur=umur;
    this.kelas=kelas;
}
//tempat membuat object
var siswa1=new Siswa("faid",20,"XII");
var siswa2=new Siswa("mahdi",15,"V")
var siswa3=new Siswa("Ilmi",17,"XI")
console.log(siswa1.umur);

