/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package weatherserver;

import java.io.IOException;
import java.util.logging.Level;
import java.util.logging.Logger;
import org.apache.xmlrpc.XmlRpcException;
import org.apache.xmlrpc.server.PropertyHandlerMapping;
import org.apache.xmlrpc.webserver.WebServer;

/**
 *
 * @author pasar
 */
public class WeatherServer {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        System.out.println("Lift off..");
        WebServer server = new WebServer(8080);
        
        PropertyHandlerMapping phm = new PropertyHandlerMapping();
        
        try {
            phm.addHandler("Weather", Weather.class);
        } catch (XmlRpcException ex) {
            Logger.getLogger(WeatherServer.class.getName()).log(Level.SEVERE, null, ex);
        }
        
        server.getXmlRpcServer().setHandlerMapping(phm);
        
        try {
            System.out.println("server starting...");
            server.start();
            
            System.out.println("started....");
            System.out.println("running on " + server.getPort());
        } catch (IOException ex) {
            Logger.getLogger(WeatherServer.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
    
}
