﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Jyx2.InputCore
{
    [AddComponentMenu("")]
    [DisallowMultipleComponent]
    public class Jyx2InputContextBase:MonoBehaviour,IJyx2_InputContext
    {
        
        protected virtual void OnEnable()
        {
            InputContextManager.Instance.AddInputContext(this);
        }

        protected virtual void OnDisable()
        {
            InputContextManager.Instance.RemoveInputContext(this);
        }

        public virtual void OnUpdate()
        {
           
        }

        public static GameObject CurrentSelect
        {
            get
            {
                return EventSystem.current?.currentSelectedGameObject;
            }
            set
            {
                EventSystem.current?.SetSelectedGameObject(value);
            }
        }
    }
}
