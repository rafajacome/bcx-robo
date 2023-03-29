using Robo.Services.Domain.DataObjects.Request;
using Robo.Services.Domain.Entities;
using Robo.Services.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Robo.Services.Service
{
    public static class ServiceHelpers
    {
        public static bool CanChangeFistState(int elbowState)
        {
            if (elbowState != (int)ElbowStateEnum.StronglyContracted)
                return true;

            return false;
        }

        public static bool CanChangeHeadState(int headInclination)
        {
            if (headInclination != (int)InclinationStateEnum.Downside)
                return true;

            return false;
        }

        public static bool IsInStateRange(int state, int newState)
        {
            if (newState > state + 1 || newState < state - 1)
                return false;

            else 
                return true;
        }

        public static ArmEntity ElbowMapper(ElbowRequest request)
        {
            var entity = new ArmEntity();

            entity.Id = request.Id;
            entity.Side = request.Side;
            entity.ElbowState = request.ElbowState;

            return entity;

        }

        public static ArmEntity FistMapper(FistRequest request)
        {
            var entity = new ArmEntity();

            entity.Id = request.Id;
            entity.Side = request.Side;
            entity.FistState = request.FistState;

            return entity;

        }

        public static HeadEntity RotationMapper(RotationRequest request)
        {
            var entity = new HeadEntity();

            entity.Id = request.Id;
            entity.RotationState = request.RotationState;

            return entity;

        }

        public static HeadEntity InclinationMapper(InclinationRequest request)
        {
            var entity = new HeadEntity();

            entity.Id = request.Id;
            entity.InclinationState = request.InclinationState;

            return entity;

        }

        public static void removeDuplicates<T>(this List<T> list)
        {
            HashSet<T> hashset = new HashSet<T>();
            list.RemoveAll(x => !hashset.Add(x));
        }
    }
}
