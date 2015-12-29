﻿using System;
using System.Runtime.CompilerServices;
using BansheeEngine;

namespace BansheeEditor
{
    /// <summary>
    /// Handles rendering of the scene gizmos for the specified camera. 
    /// </summary>
    internal sealed class SceneGizmos : ScriptObject
    {
        /// <summary>
        /// Creates a new scene gizmo renderer.
        /// </summary>
        /// <param name="sceneCamera">Camera into which the gizmos will be rendered.</param>
        internal SceneGizmos(Camera sceneCamera)
        {
            Internal_Create(this, sceneCamera.Native.GetCachedPtr());
        }

        /// <summary>
        /// Queues gizmo drawing for this frame.
        /// </summary>
        internal void Draw()
        {
            Internal_Draw(mCachedPtr);
        }

        [MethodImpl(MethodImplOptions.InternalCall)]
        private static extern void Internal_Create(SceneGizmos managedInstance, IntPtr camera);

        [MethodImpl(MethodImplOptions.InternalCall)]
        private static extern void Internal_Draw(IntPtr thisPtr);
    }
}
