/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package weatherserver;

import java.io.InputStream;
import java.net.URL;
import java.net.URLConnection;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.xml.XMLConstants;
import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;
import org.w3c.dom.Document;
import org.w3c.dom.Element;
import org.w3c.dom.Node;
import org.w3c.dom.NodeList;

/**
 *
 * @author pasar
 */
public class Weather {
    
    private static final String API_URL = "https://vrijeme.hr/hrvatska_n.xml";
    private final DocumentBuilderFactory dbf = DocumentBuilderFactory.newInstance();
    
    public double getTemperature(String cityName) {
        System.out.println("App executing..");
        double temperature = 500;
        String url = API_URL;
        try {
            URLConnection con = new URL(url).openConnection();
            try (InputStream is = con.getInputStream()) {
                dbf.setFeature(XMLConstants.FEATURE_SECURE_PROCESSING, true);
                DocumentBuilder db = dbf.newDocumentBuilder();
                con.getURL();
                Document doc = db.parse(is);
                
                Element element = doc.getDocumentElement();
                System.out.println("element log: "+element.getTagName());
                
                
                NodeList gradovi = element.getElementsByTagName("GradIme");
                System.out.println("gradovi length "+gradovi.getLength());
                for (int i = 0; i < gradovi.getLength(); i++) {
                    Node elementGrad = gradovi.item(i);
                    if (elementGrad.getTextContent().equalsIgnoreCase(cityName) 
                            || elementGrad.getTextContent().contains(cityName)) {
                        System.out.println("Nasao: "+elementGrad.getTextContent());
                        Element grad = (Element) elementGrad.getParentNode();
                        
                        NodeList temperatureList = grad.getElementsByTagName("Temp");
                        System.out.println("temp list length: "+temperatureList.getLength());
                        if (temperatureList.getLength()>0) {
                            Node tempNode = temperatureList.item(0);
                            String temp = tempNode.getTextContent();
                            System.out.println(temp);
                            temperature = Double.valueOf(temp);
                        }
                    }
                }
                
            }
        } catch (Exception ex) {
            Logger.getLogger(Weather.class.getName()).log(Level.SEVERE, null, ex);
        }
        return temperature;
    }
    
}
