package com.polshu.samplegson;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;

import com.google.gson.FieldNamingPolicy;
import com.google.gson.Gson;
import com.google.gson.GsonBuilder;
import com.google.gson.JsonArray;
import com.google.gson.JsonElement;
import com.google.gson.JsonObject;
import com.google.gson.JsonParser;

import org.json.JSONArray;

import java.util.Arrays;

public class MainActivity extends AppCompatActivity {
    //http://www.omdbapi.com/?apikey=f0e68beb&s=toy%20story
    // https://apis.datos.gob.ar/georef/api/provincias?campos=nombre
    private String strJsonString = "{'cantidad':24,'inicio':0,'parametros':{'campos':['id','nombre']},'provincias':[{'id':'54','nombre':'Misiones'},{'id':'74','nombre':'San Luis'},{'id':'70','nombre':'San Juan'},{'id':'30','nombre':'Entre Ríos'},{'id':'78','nombre':'Santa Cruz'},{'id':'62','nombre':'Río Negro'},{'id':'26','nombre':'Chubut'},{'id':'14','nombre':'Córdoba'},{'id':'50','nombre':'Mendoza'},{'id':'46','nombre':'La Rioja'},{'id':'10','nombre':'Catamarca'},{'id':'42','nombre':'La Pampa'},{'id':'86','nombre':'Santiago del Estero'},{'id':'18','nombre':'Corrientes'},{'id':'82','nombre':'Santa Fe'},{'id':'90','nombre':'Tucumán'},{'id':'58','nombre':'Neuquén'},{'id':'66','nombre':'Salta'},{'id':'22','nombre':'Chaco'},{'id':'34','nombre':'Formosa'},{'id':'38','nombre':'Jujuy'},{'id':'02','nombre':'Ciudad Autónoma de Buenos Aires'},{'id':'06','nombre':'Buenos Aires'},{'id':'94','nombre':'Tierra del Fuego, Antártida e Islas del Atlántico Sur'}],'total':24}";
/*
{
   "cantidad":24,
   "inicio":0,
   "parametros":{
      "campos":[
         "id",
         "nombre"
      ]
   },
   "provincias":[
      {
         "id":"54",
         "nombre":"Misiones"
      },
      {
         "id":"74",
         "nombre":"San Luis"
      },
      ...
   ],
   "total":24
}
* */
    // https://apis.datos.gob.ar/georef/api/provincias
    private String strJsonString2 = "{\"cantidad\":24,\"inicio\":0,\"parametros\":{},\"provincias\":[{\"centroide\":{\"lat\":-26.8753965086829,\"lon\":-54.6516966230371},\"id\":\"54\",\"nombre\":\"Misiones\"},{\"centroide\":{\"lat\":-33.7577257449137,\"lon\":-66.0281298195836},\"id\":\"74\",\"nombre\":\"San Luis\"},{\"centroide\":{\"lat\":-30.8653679979618,\"lon\":-68.8894908486844},\"id\":\"70\",\"nombre\":\"San Juan\"},{\"centroide\":{\"lat\":-32.0588735436448,\"lon\":-59.2014475514635},\"id\":\"30\",\"nombre\":\"Entre Ríos\"},{\"centroide\":{\"lat\":-48.8154851827063,\"lon\":-69.9557621671973},\"id\":\"78\",\"nombre\":\"Santa Cruz\"},{\"centroide\":{\"lat\":-40.4057957178801,\"lon\":-67.229329893694},\"id\":\"62\",\"nombre\":\"Río Negro\"},{\"centroide\":{\"lat\":-43.7886233529878,\"lon\":-68.5267593943345},\"id\":\"26\",\"nombre\":\"Chubut\"},{\"centroide\":{\"lat\":-32.142932663607,\"lon\":-63.8017532741662},\"id\":\"14\",\"nombre\":\"Córdoba\"},{\"centroide\":{\"lat\":-34.6298873058957,\"lon\":-68.5831228183798},\"id\":\"50\",\"nombre\":\"Mendoza\"},{\"centroide\":{\"lat\":-29.685776298315,\"lon\":-67.1817359694432},\"id\":\"46\",\"nombre\":\"La Rioja\"},{\"centroide\":{\"lat\":-27.3358332810217,\"lon\":-66.9476824299928},\"id\":\"10\",\"nombre\":\"Catamarca\"},{\"centroide\":{\"lat\":-37.1315537735949,\"lon\":-65.4466546606951},\"id\":\"42\",\"nombre\":\"La Pampa\"},{\"centroide\":{\"lat\":-27.7824116550944,\"lon\":-63.2523866568588},\"id\":\"86\",\"nombre\":\"Santiago del Estero\"},{\"centroide\":{\"lat\":-28.7743047046407,\"lon\":-57.8012191977913},\"id\":\"18\",\"nombre\":\"Corrientes\"},{\"centroide\":{\"lat\":-30.7069271588117,\"lon\":-60.9498369430241},\"id\":\"82\",\"nombre\":\"Santa Fe\"},{\"centroide\":{\"lat\":-26.9478001830786,\"lon\":-65.3647579441481},\"id\":\"90\",\"nombre\":\"Tucumán\"},{\"centroide\":{\"lat\":-38.6417575824599,\"lon\":-70.1185705180601},\"id\":\"58\",\"nombre\":\"Neuquén\"},{\"centroide\":{\"lat\":-24.2991344492002,\"lon\":-64.8144629600627},\"id\":\"66\",\"nombre\":\"Salta\"},{\"centroide\":{\"lat\":-26.3864309061226,\"lon\":-60.7658307438603},\"id\":\"22\",\"nombre\":\"Chaco\"},{\"centroide\":{\"lat\":-24.894972594871,\"lon\":-59.9324405800872},\"id\":\"34\",\"nombre\":\"Formosa\"},{\"centroide\":{\"lat\":-23.3200784211351,\"lon\":-65.7642522180337},\"id\":\"38\",\"nombre\":\"Jujuy\"},{\"centroide\":{\"lat\":-34.6144934119689,\"lon\":-58.4458563545429},\"id\":\"02\",\"nombre\":\"Ciudad Autónoma de Buenos Aires\"},{\"centroide\":{\"lat\":-36.6769415180527,\"lon\":-60.5588319815719},\"id\":\"06\",\"nombre\":\"Buenos Aires\"},{\"centroide\":";


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        
        TestGSON();
        
        TestGSON_Convert();
    }


    //https://howtodoinjava.com/gson/google-gson-tutorial/
    private void TestGSON_Convert() {

        //1. Default constructor
        Gson gson = new Gson();

        //2. Using GsonBuilder
        Gson gson2 = new GsonBuilder()
                .disableHtmlEscaping()
                .setFieldNamingPolicy(FieldNamingPolicy.UPPER_CAMEL_CASE)
                .setPrettyPrinting()
                .serializeNulls()
                .create();



        Empleado employee = new Empleado();
        employee.setId(1);
        employee.setNombre("Pablo");
        employee.setApellido("Ulman");
        employee.setEmails(Arrays.asList("pablo@ulman.com", "superpulman@gmail.com"));

        System.out.println(gson.toJson(employee));
        //{"id":1,"firstName":"Lokesh","lastName":"Gupta","roles":["ADMIN","MANAGER"]}



        Empleado employee2 =
                gson.fromJson(
                        "{'id':1,'firstName':'Lokesh','lastName':'Gupta','roles':['ADMIN','MANAGER']}",
                        Empleado.class
                );
    }


    private void TestGSON() {
        JsonParser  parser;
        JsonObject  respuestaJSON;
        int         intCantidad, intId;
        String      strProvincia;
        JsonArray   provinciasArrayJSON;
        JsonObject  provinciaActualJSON;

        parser      = new JsonParser();

        respuestaJSON = parser.parse(strJsonString).getAsJsonObject();

        intCantidad         = respuestaJSON.get("cantidad").getAsInt();
        provinciasArrayJSON = respuestaJSON.get("provincias").getAsJsonArray();

        Log.d("GSON: ", "Cantidad: " + String.valueOf(intCantidad));
        for (int i=0; i<provinciasArrayJSON.size(); i++){
            provinciaActualJSON = provinciasArrayJSON.get(i).getAsJsonObject();

            intId           = provinciaActualJSON.get("id").getAsInt();
            strProvincia    = provinciaActualJSON.get("nombre").getAsString();
            Log.d("GSON: ", "Id: " + String.valueOf(i) + " nombre: " + strProvincia);
        }
    }
}
