
package pokolokwium;

import java.awt.BorderLayout;
import java.awt.Color;
import java.awt.Container;
import java.awt.FlowLayout;
import java.awt.GridLayout;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

//zapis bazy
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.Statement;

import java.util.ArrayList;
import javax.swing.ButtonGroup;


import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JRadioButtonMenuItem;
import javax.swing.JScrollPane;
import javax.swing.JTable;
import javax.swing.JTextField;

import javax.swing.table.DefaultTableModel;

// xml argumenty
import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;
import javax.xml.transform.Result;
import javax.xml.transform.Source;
import javax.xml.transform.Transformer;
import javax.xml.transform.TransformerFactory;
import javax.xml.transform.dom.DOMSource;
import javax.xml.transform.stream.StreamResult;

import org.hibernate.Query;
import org.hibernate.Session;
import org.hibernate.SessionFactory;
import org.hibernate.cfg.Configuration;

import org.w3c.dom.Document;
import org.w3c.dom.Element;
import org.w3c.dom.NodeList;


public class GUI extends JFrame implements ActionListener
{

    Container zawartoscRamki; // calosc
    JPanel panelTabeli, panelGlowny,panelDanych,panelDanych2;
      
    JLabel etformat,komunikaty,formatet,liczba_Karteket,cenaet,opisbuttonet,opisdrukowanedodajelementet;
    JRadioButtonMenuItem radioformatw,radioformat1,radioformat2,radioformat3,radioformat4; //radio button
    
    JButton przycisk1,przycisk2,przycisk3,przycisk4,przycisk5,przycisk6;
    
    JTable tabela;
    DefaultTableModel modelTabeli;
    
    JTextField formattext,liczba_Kartektext,cenatext;

    private int idid = 0; //glowne id tabeli
     
    public ArrayList<Zeszyt> kolekcja = new ArrayList<Zeszyt>();
    public ArrayList<Zeszyt> kolekcjacala = new ArrayList<Zeszyt>();
    
    public GUI() // konstruktor
    {
    super ("Kolokwium nr 1");
    this.setSize(700, 650);
     
     
        this.zawartoscRamki=this.getContentPane(); // calosc - szybka warstwa wywietlenia
        
        this.panelDanych = new JPanel(new GridLayout(23,1));
         //this.panelDanych.setBackground(Color.white);
         
        this.panelGlowny = new JPanel(new BorderLayout());        
       
        //panel danych (panel lewy)
        this.etformat = new JLabel("ZAZNACZ 'FORMAT' DO ODCZYTU:");
          this.panelDanych.add(this.etformat);
          
        //this.panelDanych.add(new JPanel()); //puste
          
        this.radioformatw = new JRadioButtonMenuItem("WSZYSTKIE");
          this.panelDanych.add(this.radioformatw);
        
        this.radioformat1 = new JRadioButtonMenuItem("A4");
          this.panelDanych.add(this.radioformat1);
        this.radioformat2 = new JRadioButtonMenuItem("B2");
          this.panelDanych.add(this.radioformat2);
        this.radioformat3 = new JRadioButtonMenuItem("A5");
          this.panelDanych.add(this.radioformat3);
        this.radioformat4 = new JRadioButtonMenuItem("A2");
          this.panelDanych.add(this.radioformat4);

        ButtonGroup grupa = new ButtonGroup();
        grupa.add(radioformatw);
        grupa.add(radioformat1);
        grupa.add(radioformat2);
        grupa.add(radioformat3);
        grupa.add(radioformat4);
        
        this.przycisk1 = new JButton("Filtruj/Wczytaj XML");
        przycisk1.setBackground(Color.blue);
         this.przycisk1.addActionListener(this);
        this.panelDanych.add(przycisk1);
        
        this.przycisk2 = new JButton("Zapisz XML");
        przycisk2.setBackground(Color.green);
         this.przycisk2.addActionListener(this);
        this.panelDanych.add(przycisk2);
    
        this.przycisk3 = new JButton("Filtruj/Wczytaj bazę Hibernate");
        przycisk3.setBackground(Color.blue);
         this.przycisk3.addActionListener(this);
        this.panelDanych.add(przycisk3);
        
        this.przycisk4 = new JButton("Zapisz bazę");
        przycisk4.setBackground(Color.green);
         this.przycisk4.addActionListener(this);
        this.panelDanych.add(przycisk4);
        
        this.przycisk5 = new JButton("Wyczyść tabele i kolekcje");
        przycisk5.setBackground(Color.red);
         this.przycisk5.addActionListener(this);
        this.panelDanych.add(przycisk5);
                
        this.panelDanych.add(new JPanel()); //puste
        
        this.formatet = new JLabel("DODAJ RĘCZNIE ELEMENT DO TABELI:");  
          this.panelDanych.add(this.formatet);
        
        this.formatet = new JLabel("Podaj Format:");  
          this.panelDanych.add(this.formatet);
        
        this.formattext = new JTextField();
          this.panelDanych.add(this.formattext);
          
        this.liczba_Karteket = new JLabel("Podaj Liczbę Kartek:");  
          this.panelDanych.add(this.liczba_Karteket);
          
        this.liczba_Kartektext = new JTextField();
          this.panelDanych.add(this.liczba_Kartektext);
          
        this.cenaet = new JLabel("Podaj Cene:");  
          this.panelDanych.add(this.cenaet);

        this.cenatext = new JTextField();
          this.panelDanych.add(this.cenatext);
          
        this.opisbuttonet = new JLabel("Kliknij 'Dodaj' aby dodać do tabeli:");  
          this.panelDanych.add(this.opisbuttonet);

        this.przycisk6 = new JButton("Dodaj");
        przycisk6.setBackground(Color.pink);
         this.przycisk6.addActionListener(this);
          this.panelDanych.add(przycisk6);
        
          this.panelDanych.add(new JPanel()); //puste
          
        komunikaty = new JLabel("Komunikat: Wybierz format, aby odczytać!");
         panelDanych.add(komunikaty);
        
        
this.panelDanych2=new JPanel(new FlowLayout()); //pokolei, jeden za drugim w jednym rzędzie - kolejny wiersz kiedy ramka za mała
   // this.panelDanych2.setBackground(Color.white);
this.panelDanych2.add(this.panelDanych);
this.panelGlowny.add(this.panelDanych2,BorderLayout.WEST);       
//this.panelGlowny.add(this.panelDanych,BorderLayout.WEST);
        
        
        //panel srodkowy
        this.panelTabeli = new JPanel(new BorderLayout());

        this.modelTabeli = new DefaultTableModel();
        this.modelTabeli.addColumn("Format");
        this.modelTabeli.addColumn("Liczba kartek");
        this.modelTabeli.addColumn("Cena");
        this.modelTabeli.addColumn("Id");
        this.tabela = new JTable(this.modelTabeli);
        
        this.panelTabeli.add(new JScrollPane(this.tabela)); // JScrollPane pobiera dane o potrzebnym rozmiarze
        this.panelGlowny.add (this.panelTabeli, BorderLayout.CENTER);

        
        this.zawartoscRamki.add(this.panelGlowny);


     
    this.setDefaultCloseOperation(EXIT_ON_CLOSE);
    this.setVisible(true);
        
     
    }
    
    @Override
    public void actionPerformed(ActionEvent e)
    {
            
      if(e.getActionCommand().equals("Filtruj/Wczytaj XML"))
      {
          try
          {
              
          DocumentBuilderFactory fabryka = DocumentBuilderFactory.newInstance();
          DocumentBuilder parser = fabryka.newDocumentBuilder();
          Document dokument  = parser.parse("KolokwiumZeszyt.xml");
          Element root = dokument.getDocumentElement();
          NodeList ksiazka = root.getElementsByTagName("zeszyt"); //tag danego elementu
            
                
                for(int i=0 ; i<ksiazka.getLength();i++)
                {
                String format = null;
                
                    if(radioformat1.isSelected() && ((Element)ksiazka.item(i)).getAttribute("format").equals("A4"))
                    {
                        format =((Element)ksiazka.item(i)).getAttribute("format");
                    }
                    else if(radioformat2.isSelected() && ((Element)ksiazka.item(i)).getAttribute("format").equals("B2"))
                    {
                        format =((Element)ksiazka.item(i)).getAttribute("format");
                    }
                    else if(radioformat3.isSelected() && ((Element)ksiazka.item(i)).getAttribute("format").equals("A5"))
                    { 
                        format =((Element)ksiazka.item(i)).getAttribute("format");
                    }
                    else if(radioformat4.isSelected() && ((Element)ksiazka.item(i)).getAttribute("format").equals("A2"))
                    {
                        format =((Element)ksiazka.item(i)).getAttribute("format");
                    }
                    else if(radioformatw.isSelected())
                    {
                        format =((Element)ksiazka.item(i)).getAttribute("format");
                    }
                  
                    
                    if(format!=null)
                    {

                    int liczba_Kartek = Integer.parseInt(((Element)ksiazka.item(i)).getAttribute("liczba_Kartek"));
                    float cena = Float.parseFloat(((Element)ksiazka.item(i)).getAttribute("cena"));
                    //int id = Integer.parseInt(((Element)ksiazka.item(i)).getAttribute("id"));
                    
                    Zeszyt obiekZeszyt = new Zeszyt(format,liczba_Kartek,cena);
                    kolekcjacala.add(obiekZeszyt);

                    Object[] dane = new Object[4];
                    dane[0]=obiekZeszyt.getFormat();
                    dane[1]=obiekZeszyt.getLiczba_Kartek();
                    dane[2]=obiekZeszyt.getCena();
                    dane[3]=idid;
                    idid++;
                    
                    this.modelTabeli.addRow(dane);
                     System.out.println("Wczytałem - XML!");
                      komunikaty.setText("Komunikat: Wczytałem - XML!");
                    }
                    
                }
                  
         
         
          }
          catch(Exception ex)
          {
              System.out.println("Komunikat: "+ ex);
           komunikaty.setText("Komunikat: Błąd! "+ex.getMessage());
          }
      }
      if(e.getActionCommand().equals("Zapisz XML"))
      {
            try
            {
                DocumentBuilderFactory fabryka = DocumentBuilderFactory.newInstance();
                DocumentBuilder parser = fabryka.newDocumentBuilder();
                Document dokument  = parser.newDocument();

                Element root = dokument.createElement("zeszyty");
                dokument.appendChild(root);

                int id2=0;
                for(Zeszyt z :kolekcjacala)
                {
                    Element element = dokument.createElement("zeszyt");
                    element.setAttribute("format", z.getFormat());
                    element.setAttribute("liczba_Kartek", String.valueOf(z.getLiczba_Kartek()));
                    element.setAttribute("cena", String.valueOf(z.getCena()));
                    element.setAttribute("id", String.valueOf(id2));
                    root.appendChild(element);
                    id2++;
                }

                Transformer przekszt = TransformerFactory.newInstance().newTransformer();
                Source zrodlo = new DOMSource(dokument);

                Result wyjscie = new StreamResult("Zapisany-XML.xml");
                przekszt.transform(zrodlo,wyjscie);
                System.out.println("Zapisałem - XML!");
                komunikaty.setText("Komunikat: Zapisałem - XML!");
            }
            catch(Exception ex)
            {
              System.out.println("Komunikat: "+ ex);
             komunikaty.setText("Komunikat: Błąd! "+ex.getMessage());
            }
      }
      
      
       if(e.getActionCommand().equals("Filtruj/Wczytaj bazę Hibernate"))
      {
  
          try
          {
          SessionFactory fabrykaSesji = new Configuration().configure("pokolokwium/hibernate.cfg.xml").buildSessionFactory();
          
          
          Session sesja = fabrykaSesji.openSession();
          
          Query zapytanie = null;
          
                if(radioformat1.isSelected())
                {
                    zapytanie = sesja.createQuery("FROM Zeszyt WHERE Format='A4'"); //nazwa klasy - mapowalnej
                }
                else if(radioformat2.isSelected())
                {
                    zapytanie = sesja.createQuery("FROM Zeszyt WHERE Format='B2'"); //nazwa klasy - mapowalnej
                }
                else if(radioformat3.isSelected())
                {
                    zapytanie = sesja.createQuery("FROM Zeszyt WHERE Format='A5'"); //nazwa klasy - mapowalnej
                }
                else if(radioformat4.isSelected())
                {
                    zapytanie = sesja.createQuery("FROM Zeszyt WHERE Format='A2'"); //nazwa klasy - mapowalnej
                }
                else if(radioformatw.isSelected())
                {
                    zapytanie = sesja.createQuery("FROM Zeszyt"); //nazwa klasy - mapowalnej
                }
            
               if(zapytanie!=null)
               {

                   
                    kolekcja = ((ArrayList<Zeszyt>)zapytanie.list());
                    kolekcjacala.addAll((ArrayList<Zeszyt>)zapytanie.list());

                    for(Zeszyt z: kolekcja)
                    {

                    Object[] dane = new Object[4];
                    dane[0]=z.getFormat();
                    dane[1]=z.getLiczba_Kartek();
                    dane[2]=z.getCena();
                    dane[3]=idid;
                    idid++;

                    this.modelTabeli.addRow(dane);
                    }
                    
                    System.out.println("Odczytałem bazę!");
                    komunikaty.setText("Komunikat: Odczytałem bazę!");

               }
              
               
          sesja.close();
            
           
          }
           catch(Exception ex)
          {
              System.out.println("Komunikat: "+ ex);
              komunikaty.setText("Komunikat: Błąd! "+ex.getMessage());
          }

      }
      
      if(e.getActionCommand().equals("Zapisz bazę"))
      {
        Connection polaczenie;
        try
        {
            Class.forName("com.mysql.jdbc.Driver").newInstance();
            polaczenie = DriverManager.getConnection("jdbc:mysql://localhost/zeszyt", "root", "root");
            System.out.println(polaczenie);
            Statement instrukcja = polaczenie.createStatement();
            instrukcja.executeUpdate("DELETE FROM zeszyt");
                    
                    int id2=0;
                    for(Zeszyt z :kolekcjacala)
                    {
           
                        String sql = "INSERT INTO zeszyt SET ";
                        sql+="Format='"+z.getFormat()+"',";
                        sql+="Liczba_kartek='"+z.getLiczba_Kartek()+"',";
                        sql+="Cena='"+z.getCena()+"',";
                        sql+="Id='"+id2+"'";
                         
                        //System.out.println(sql);
                        
                        instrukcja.executeUpdate(sql);
                        id2++;
                    }    
                  
               polaczenie.close();
               
               System.out.println("Zapisałem bazę!");
               komunikaty.setText("Komunikat: Zapisałem bazę!");
        }
         catch(Exception ex)
          {
              System.out.println("Komunikat: "+ ex);
               komunikaty.setText("Komunikat: Błąd! "+ex.getMessage());
          }
          
      } 
      
      
      if(e.getActionCommand().equals("Wyczyść tabele i kolekcje"))
      {

          for(int i=0 ; i<kolekcjacala.size();i++)
          this.modelTabeli.removeRow(0);
          kolekcjacala.clear();
          kolekcja.clear();
          idid=0;
           System.out.println("Dane zostały wyczyszczone!");
           komunikaty.setText("Komunikat: Dane zostały wyczyszczone!");
      }
      
      if(e.getActionCommand().equals("Dodaj"))
      {
          
          try
          {
          
          Zeszyt obiekZeszyt = new Zeszyt(formattext.getText(),Integer.parseInt(liczba_Kartektext.getText()),Float.parseFloat(cenatext.getText()));
          kolekcjacala.add(obiekZeszyt);

          Object[] dane = new Object[4];
          dane[0]=obiekZeszyt.getFormat();
          dane[1]=obiekZeszyt.getLiczba_Kartek();
          dane[2]=obiekZeszyt.getCena();
          dane[3]=idid;
          idid++;
          
          this.modelTabeli.addRow(dane);
          
          System.out.println("Dodałem!");
           komunikaty.setText("Komunikat: Dodałem!");
          }
          catch(Exception ex)
          {
              System.out.println("Komunikat: "+ ex);
               komunikaty.setText("Komunikat: Błąd! "+ex.getMessage());
          }
          
      }
      
      
      
      
    }
    
    
}
