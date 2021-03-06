﻿using System;

namespace SMokaEngine
{
	public class Component
	{
		public bool Enabled { get; set; }

		private Entity entity;
		public Entity Entity
		{
			get
			{
				return entity;
			}

			set
			{
				if (entity == null)
				{
					entity = value;
				}
				else
				{
					throw new SMokaException("Component's entity already set.");
				}
			}
		}

		public Context Context
		{
			get
			{
				return entity.Context;
			}
		}

		public Application Application
		{
			get
			{
				return Entity.Context.App;
			}
		}

		public Component()
		{
			Enabled = true;
		}

		public Transform Transform
		{
			get
			{
				return entity.Transform;
			}
		}

		public virtual void OnCreate()
		{

		}

		public virtual void OnUpdate()
		{

		}

		public virtual void OnPostUpdate()
		{

		}

		public virtual void OnDestroy()
		{

		}
	}
}

