/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package hr.algebra.controller;

import generated.ArrayOfMotorcycle;
import java.io.File;
import java.io.IOException;
import java.net.URL;
import java.util.ResourceBundle;
import java.util.logging.Level;
import java.util.logging.Logger;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.Initializable;
import javafx.scene.control.Button;
import javafx.scene.control.TextField;
import javax.swing.JFileChooser;
import javax.swing.filechooser.FileNameExtensionFilter;
import javax.swing.filechooser.FileSystemView;
import javax.xml.XMLConstants;
import javax.xml.bind.JAXBContext;
import javax.xml.bind.JAXBException;
import javax.xml.bind.Unmarshaller;
import javax.xml.transform.stream.StreamSource;
import javax.xml.validation.Schema;
import javax.xml.validation.SchemaFactory;
import javax.xml.validation.Validator;
import org.xml.sax.SAXException;

/**
 * FXML Controller class
 *
 * @author Mladen
 */
public class JAXBViewController implements Initializable {

    @FXML
    private Button btnChoose;
    @FXML
    private TextField tfResult;

    /**
     * Initializes the controller class.
     */
    @Override
    public void initialize(URL url, ResourceBundle rb) {
        // TODO
    }

    @FXML
    private void validateXML(ActionEvent event) {
        String xmlFilePath = "C:\\Users\\pasar\\Desktop"
                + "\\Soap_file\\motorcycles.xml";
        File xmlFile = new File(xmlFilePath);
        JFileChooser jfc = new JFileChooser(FileSystemView.getFileSystemView());

        int returnValue = jfc.showOpenDialog(null);

        if (returnValue == JFileChooser.APPROVE_OPTION) {
            //File selectedFile = chooseXmlSchema(jfc);

            /*boolean isValid = validateSoapXml(selectedFile.getAbsolutePath(), xmlFilePath);
            tfResult.setText(isValid ? "Xml is valid against schema" : "Xml is not valid");*/
            try {
                File selectedFile = chooseXmlSchema(jfc);

                JAXBContext context = JAXBContext.newInstance(ArrayOfMotorcycle.class);
                Unmarshaller jaxbUnmarshaller = context.createUnmarshaller();
                SchemaFactory schemaFactory = SchemaFactory
                        .newInstance(XMLConstants.W3C_XML_SCHEMA_NS_URI);
                Schema schema = schemaFactory.newSchema(selectedFile);
                jaxbUnmarshaller.setSchema(schema);
                ArrayOfMotorcycle m = (ArrayOfMotorcycle) jaxbUnmarshaller.unmarshal(new StreamSource(new File(xmlFilePath)));
                tfResult.setText("Xml is valid");
            } catch (JAXBException | SAXException ex) {
                Logger.getLogger(JAXBViewController.class.getName()).log(Level.SEVERE, null, ex);
                tfResult.setText("Xml is not valid");

            }
        }
    }

    private File chooseXmlSchema(JFileChooser jfc) {
        jfc.setDialogTitle("Select xml schema");
        jfc.setAcceptAllFileFilterUsed(false);
        FileNameExtensionFilter filter
                = new FileNameExtensionFilter("XSD files", "xsd");
        jfc.addChoosableFileFilter(filter);

        File selectedFile = jfc.getSelectedFile();
        System.out.println("path: " + selectedFile.getAbsolutePath());
        return selectedFile;
    }

    private boolean validateSoapXml(String xsdFilePath, String xmlFilePath) {
        SchemaFactory schemaFactory = SchemaFactory
                .newInstance(XMLConstants.W3C_XML_SCHEMA_NS_URI);
        try {
            Schema schema = schemaFactory.newSchema(new File(xsdFilePath));
            Validator validator = schema.newValidator();
            validator.validate(new StreamSource(new File(xmlFilePath)));
        } catch (SAXException | IOException ex) {
            Logger.getLogger(JAXBViewController.class.getName()).log(Level.SEVERE, null, ex);
            return false;
        }
        return true;
    }

}
