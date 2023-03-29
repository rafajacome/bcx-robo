using Qyon.AdventureServices.Domain.DataObjects.Competidores.Request;
using Qyon.AdventureServices.Domain.DataObjects.Corrida.Request;
using Qyon.AdventureServices.Domain.DataObjects.Pista.Request;
using Qyon.AdventureServices.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Qyon.AdventuresServices.Service
{
    public static class ServiceHelpers
    {
        public static bool IsPositive(this decimal number)
        {
            return number > 0;
        }

        public static bool IsNegative(this decimal number)
        {
            return number < 0;
        }

        public static bool IsZero(this decimal number)
        {
            return number == 0;
        }

        public static bool TemperatureInBetween36And38(this decimal number)
        {
            return (number >= 36 && number <= 38);
        }


        public static bool VerifyGender(char gender)
        {
            return (gender == 'F' | gender == 'M' | gender == 'O');
        }

        public static CompetidoresEntity CompetidorMapper(CompetidorRequest request)
        {
            var entity = new CompetidoresEntity();

            entity.Id = request.Id;
            entity.Nome = request.Nome;
            entity.Altura = request.Altura;
            entity.TemperaturaMediaCorpo = request.TemperaturaMediaCorpo;
            entity.Sexo = request.Sexo;

            return entity;

        }

        public static PistaEntity PistaMapper(PistaRequest request)
        {
            var entity = new PistaEntity();

            entity.Id = request.Id;
            entity.Descricao = request.Descricao;

            return entity;

        }

        public static CorridaEntity CorridaMapper(CorridaRequest request)
        {
            var entity = new CorridaEntity();

            entity.Id = request.Id ;
            entity.IdPista = request.Id;
            entity.IdCompetidor = request.IdCompetidor;
            entity.DataCorrida = Convert.ToDateTime(request.DataCorrida);

            return entity;

        }

        public static CompetidoresEntity CreateCompetidorMapper(CreateCompetidorRequest request)
        {
            var entity = new CompetidoresEntity();
            
            entity.Nome = request.Nome;
            entity.Altura = request.Altura;
            entity.TemperaturaMediaCorpo = request.TemperaturaMediaCorpo;
            entity.Sexo = request.Sexo;
            entity.Peso = request.Peso;

            return entity;

        }

        public static PistaEntity CreatePistaMapper(CreatePistaRequest request)
        {
            var entity = new PistaEntity();

            entity.Descricao = request.Descricao;

            return entity;

        }

        public static CorridaEntity CreateCorridaMapper(CreateCorridaRequest request)
        {
            var entity = new CorridaEntity();

            entity.IdPista = request.IdPista;
            entity.IdCompetidor = request.IdCompetidor;
            entity.DataCorrida = Convert.ToDateTime(request.DataCorrida);
            entity.TempoGasto = request.TempoGasto;

            return entity;

        }

        public static void removeDuplicates<T>(this List<T> list)
        {
            HashSet<T> hashset = new HashSet<T>();
            list.RemoveAll(x => !hashset.Add(x));
        }
    }
}
