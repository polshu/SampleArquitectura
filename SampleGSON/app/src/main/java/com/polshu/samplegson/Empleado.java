package com.polshu.samplegson;

import java.util.Date;
import java.util.List;

public class Empleado
{
    private Integer         id;
    private String          strNombre;
    private String          strApellido;
    private Date            dtmFechaNacimiento;
    private List<String>    emailList;

    public Empleado(){
    }

    public Empleado(Integer id){
        this.id                 = 0;
        this.strNombre          = "";
        this.strApellido        = "";
        this.dtmFechaNacimiento = new Date();
    }

    //Getters and setters
    public void     setId (int id){ this.id = id;}
    public int      getId (){ return id;}

    public void     setNombre (String nombre){ this.strNombre = nombre;}
    public String   getNombre (){ return strNombre;}

    public void     setApellido (String apellido){ this.strApellido = apellido;}
    public String   getApellido (){ return strApellido;}

    public void     setFechaNacimiento (Date fechaNacimiento){ this.dtmFechaNacimiento = fechaNacimiento;}
    public Date     getFechaNacimiento (){ return dtmFechaNacimiento;}

    public void     setEmails (List<String> newEmailList){
        this.emailList.clear();
        if ((newEmailList!= null) && newEmailList.size() > 0){
            this.emailList.addAll(newEmailList);
        }
    }

    //

    @Override
    public String toString()
    {
        return "Empleado [id=" + id + ", firstName=" + strNombre + ", " +
                "lastName=" + strApellido + ", roles=" + emailList + "]";
    }
}
