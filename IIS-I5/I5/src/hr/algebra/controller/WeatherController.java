 /*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package hr.algebra.controller;

import java.net.MalformedURLException;
import java.net.URL;
import java.util.ResourceBundle;
import java.util.logging.Level;
import java.util.logging.Logger;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.Initializable;
import javafx.scene.control.Button;
import javafx.scene.control.TextField;
import org.apache.xmlrpc.XmlRpcException;
import org.apache.xmlrpc.client.XmlRpcClient;
import org.apache.xmlrpc.client.XmlRpcClientConfigImpl;

/**
 * FXML Controller class
 *
 * @author pasar
 */
public class WeatherController implements Initializable {

    @FXML
    private TextField tfCity, tfTemperature;

    @FXML
    private Button btnGetData;

    /**
     * Initializes the controller class.
     */
    @Override
    public void initialize(URL url, ResourceBundle rb) {
        // TODO
    }

    @FXML
    private void getData(ActionEvent event)  {
        
        XmlRpcClientConfigImpl clientConfig = new XmlRpcClientConfigImpl();
        
        try {
            clientConfig.setServerURL(new URL("http://localhost:8080"));
        } catch (MalformedURLException ex) {
            Logger.getLogger(WeatherController.class.getName()).log(Level.SEVERE, null, ex);
        }
        
        XmlRpcClient client = new XmlRpcClient();
        client.setConfig(clientConfig);
        
        String cityName = tfCity.getText().trim();
        
        Object[] parameter = new Object[]{cityName};
        double temperature = 3;
        
        try {
            temperature = (double) client.execute("Weather.getTemperature", parameter);
        } catch (XmlRpcException ex) {
            Logger.getLogger(WeatherController.class.getName()).log(Level.SEVERE, null, ex);
        }
        tfTemperature.setText(String.valueOf(temperature) + " °C");
        
    }

}
