<!DOCTYPE html>
<html lang="tr">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink to fit=no">
    <title>Ana Sayfa</title>
    <link rel="stylesheet" href="css/login.css">
    <link rel="stylesheet" href="boostrap.css">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.0.13/css/all.css" integrity="sha384-DNOHZ68U8hZfKXOrtjWvjxusGo9WQnrNx2sqG0tfsghAvtVlRW3tvkXWZh58N9jp" crossorigin="anonymous">
    <script src="https://kit.fontawesome.com/1922f4bd30.js" crossorigin="anonymous"></script>

</head>

<body id="anasayfa1">

    <!--Menu Kismi-->

    <!--Menu kismi-->

    <div class="admin">
        <div class="row">
            <div class="col adminIletisimTablo">
                <?php if ($_POST["name"] == "G211210031@sakarya.edu.tr" && $_POST["password"] == "G211210031") {
                    echo "Hoşgeldin " . $_POST["name"];
                    echo "<br>Girişin Onaylandı.";
                } else {
                    echo "Kullanıcı epostası yada şifre hatalı";
                    header("refresh:2; login.html");
                }
                ?>
            </div>
        </div>
    </div>

    <footer class="py-3 text-white   text-center clr">
        <p>Web-Teknolojileri-Projesi Metehan Dündar 2022</p>
        <p>
            <a href="https://github.com/EdepHuu?tab=repositories" class="Link"><i class="fab fa-github" id="icon1"></i>
                Github</a>
            <a href="https://www.instagram.com/metehanndundar/" class="Link"><i class="fa-brands fa-instagram" id="icon1"></i>İnstagram</a>
            <a href="https://www.linkedin.com/in/metehan-dündar-882974226" class="Link"><i class="fa-brands fa-linkedin" id="icon1"></i>Linkedin</a>
        </p>
    </footer>



    <!-- Option 2: Separate Popper and Bootstrap JS -->

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0/dist/js/bootstrap.bundle.min.js" integrity="sha384-p34f1UUtsS3wqzfto5wAAmdvj+osOnFyQFpp4Ua3gs/ZVWx6oOypYoCJhGGScy+8" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.9.2/dist/umd/popper.min.js" integrity="sha384-IQsoLXl5PILFhosVNubq5LC7Qb9DXgDA9i+tQ8Zj3iwWAwPtgFTxbJ8NT4GN1R8p" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0/dist/js/bootstrap.min.js" integrity="sha384-lpyLfhYuitXl2zRZ5Bn2fqnhNAKOAaM/0Kr9laMspuaMiZfGmfwRNFh8HlMy49eQ" crossorigin="anonymous"></script>


    <script src="boostrap.js"></script>
</body>

</html>