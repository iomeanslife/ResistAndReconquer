//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using UnityEngine;

		public struct AnimationInstruction
		{
	public Vector3 startPosition, endPosition, startRotation, endRotation, startScale, endScale;
	public TimeSpan duration;
	public InstructionDef instructionDef;
		}

[Flags]
public enum InstructionDef
{
	None = 0,
	Position = 1,
	Rotation = 2,
	Scaling = 4
}
