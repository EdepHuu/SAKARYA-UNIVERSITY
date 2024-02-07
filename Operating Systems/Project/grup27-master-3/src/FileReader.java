import java.io.*;

public class FileReader {
    public String file_path;//Okunacak olan dosyan�n yolunu tutar.
    public Process process = new Process();//Process s�n�f�ndan bir nesne olu�turulur.
    public Queue jobDispatchList = new Queue();//Queue s�n�f�ndan bir nesne olu�turulur.

    public FileReader(String _file_path)/*Yap�c� s�n�fa dosya yolu verilir.*/
    {
        this.file_path = _file_path;
    }

    public void ReadFromFile() {
        String str;

        try {
            //Dosya okuma operasyonu burada ger�ekle�ir.
            FileInputStream fStream = new FileInputStream(this.file_path);//Dosya yolundan veriler okunur ve buffera at�l�r.
            DataInputStream dStream = new DataInputStream(fStream);
            BufferedReader bReader = new BufferedReader(new InputStreamReader(dStream));
            //Dosyan�n sonuna kadar oku ve her sat�rda yeni process olu�tur.
            while ((str = bReader.readLine()) != null) {//Buffer�n her sat�r� gezilir ve e�er null de�ilse yeni bir process nesnesi olu�turulup bu stringi parametre olarak verir.
                Process new_process = process.CreateNewProcess(str);
                jobDispatchList.AddProcessToJob(new_process);//Olu�turulan yeni nesneyi kuyruk nesnesine atama yapar.
                ProcessBuilder processBuilder = new ProcessBuilder(str);//Proses buildera atan�r.
            }
            dStream.close();//ba�lant� kapat�l�r.
            jobDispatchList.SplitQueue();//Queue s�n�f�n�n SplitQueue fonksiyonu �a��r�l�r.
            int length = jobDispatchList.QueueLength();//kuyruktaki verilerin uzunlu�u length de�i�kenine atan�r.
            int i=0;
            while(i<length){//kuyruktaki verilerin uzunlu�u kadar d�ner
                jobDispatchList.RunProcess();//Kuyruk i�leme ba�lat�l�r. Queuenin RunProcess metoduna gider.
                i++;
            }
            // jobDispatchList.PrintProcess();
            //close the file
        } catch (Exception e) {//hata varsa exception f�rlat�r.
            System.err.println("Error : " + e.getMessage());
        }
    }
}