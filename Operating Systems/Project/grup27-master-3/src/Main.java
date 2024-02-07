import java.io.FileNotFoundException;

public class Main {
    public static void main(String[] args) {
    	FileReader f1 = new FileReader(args[0]);//dosya yolu verilir. CMDden gelen dosya adı. dist klasörünün içinde olmalı.
        f1.ReadFromFile();//Dosya okuma metodunu �a��r�r.
        ProcessLogger.printProcessTable();
    }
}
