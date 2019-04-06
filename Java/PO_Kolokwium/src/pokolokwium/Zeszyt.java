
package pokolokwium;

import java.io.Serializable;

public class Zeszyt extends Zeszyt2 implements Serializable
{
    
    private String format;
    private int liczba_Kartek;
    private int id; // do hibernate

    //Interceptory są wykorzystywane do realizacji przekrojowych problemów, takich jak rejestrowanie, 
    //audyt i bezpieczeństwo, z logiki biznesowej.
    public Zeszyt()
    {
        
    }

    
    public int getId() {
        return id;
    }
    
    public void setId(int id) {
        this.id = id;
    }
    
    
    public Zeszyt(String format, int liczba_Kartek, float cena) {
        super(cena); // wywoluje konstruktor klasy pochodnej
        this.format = format;
        this.liczba_Kartek = liczba_Kartek;
    }

    public String getFormat() {
        return format;
    }

    public int getLiczba_Kartek() {
        return liczba_Kartek;
    }

    public void setFormat(String format) {
        this.format = format;
    }

    public void setLiczba_Kartek(int liczba_Kartek) {
        this.liczba_Kartek = liczba_Kartek;
    }

    
    
    
    
    
}
