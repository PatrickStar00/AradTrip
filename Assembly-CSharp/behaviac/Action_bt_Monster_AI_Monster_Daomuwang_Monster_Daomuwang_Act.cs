﻿using System;
using System.Collections.Generic;

namespace behaviac
{
	// Token: 0x0200361F RID: 13855
	[GeneratedTypeMetaInfo]
	internal class Action_bt_Monster_AI_Monster_Daomuwang_Monster_Daomuwang_Action_node30 : Action
	{
		// Token: 0x06015462 RID: 87138 RVA: 0x00669F9C File Offset: 0x0066839C
		public Action_bt_Monster_AI_Monster_Daomuwang_Monster_Daomuwang_Action_node30()
		{
			this.m_resultOption = EBTStatus.BT_SUCCESS;
			this.method_p0 = new List<Input>();
			this.method_p0.Capacity = 1;
			Input item = default(Input);
			item.delay = 0;
			item.moveInSkillState = false;
			item.moveKeepDistance = 0;
			item.PKRobotComboCheck = false;
			item.pressTime = 0;
			item.randomChangeDirection = false;
			item.skillID = 5430;
			item.specialChoice = 0;
			this.method_p0.Add(item);
			this.method_p1 = false;
		}

		// Token: 0x06015463 RID: 87139 RVA: 0x0066A02C File Offset: 0x0066842C
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			((BTAgent)pAgent).Action_DoAction(ref this.method_p0, this.method_p1);
			return EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400EE1B RID: 60955
		private List<Input> method_p0;

		// Token: 0x0400EE1C RID: 60956
		private bool method_p1;
	}
}
