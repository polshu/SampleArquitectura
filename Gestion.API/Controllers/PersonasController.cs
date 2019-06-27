﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using Helpers;
using Gestion.Entities;
using Gestion.API.Models;
using Gestion.Services;

namespace Gestion.API.Controllers {
    public class PersonasController : ApiController {

        [HttpGet]
        [Route("api/v1/personas/{id}")]
        public IHttpActionResult GetById(int id) {
            IHttpActionResult   respuesta;
            Persona             oPersona;
        
            oPersona = PersonasService.GetById(id);
            if (oPersona != null) {
                respuesta = Ok(oPersona);
            } else {
                respuesta = NotFound();
            }

            return respuesta;
        }

        [HttpGet]
        [Route("api/v1/personas")]
        public IHttpActionResult GetAll() {
            IHttpActionResult respuesta;
            List<Persona> personasList;

            personasList    = PersonasService.GetAll();
            respuesta       = Ok(personasList);

            return respuesta;
        }

        [HttpPost]
        [Route("api/v1/personas")]
        public IHttpActionResult Insert(Persona requestDTO) {
            IHttpActionResult   respuesta;
            ResponseDTO         responseDTO = new ResponseDTO();

            int     intNewId;
            string  strErrores = "";

            //intNewId = PersonasService.Insert(newPersona);
            //intNewId = PersonasService.InsertScalar(newPersona);
            intNewId = PersonasService.InsertValid(requestDTO, out strErrores);

            if (intNewId > 0) {
                responseDTO.NewId = intNewId;
                respuesta = Ok(responseDTO);
            } else {
                responseDTO.NewId   = 0;
                responseDTO.Errores = strErrores;
                respuesta = Ok(responseDTO);
            }

            return respuesta;
        }
        
    }
}