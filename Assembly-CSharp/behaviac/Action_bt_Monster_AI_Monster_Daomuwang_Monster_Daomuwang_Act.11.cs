﻿using System;
using System.Collections.Generic;

namespace behaviac
{
	// Token: 0x02003648 RID: 13896
	[GeneratedTypeMetaInfo]
	internal class Action_bt_Monster_AI_Monster_Daomuwang_Monster_Daomuwang_Action_maoxian_node20 : Action
	{
		// Token: 0x060154B3 RID: 87219 RVA: 0x0066B838 File Offset: 0x00669C38
		public Action_bt_Monster_AI_Monster_Daomuwang_Monster_Daomuwang_Action_maoxian_node20()
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
			item.skillID = 5426;
			item.specialChoice = 0;
			this.method_p0.Add(item);
			this.method_p1 = false;
		}

		// Token: 0x060154B4 RID: 87220 RVA: 0x0066B8C8 File Offset: 0x00669CC8
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			((BTAgent)pAgent).Action_DoAction(ref this.method_p0, this.method_p1);
			return EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400EE6B RID: 61035
		private List<Input> method_p0;

		// Token: 0x0400EE6C RID: 61036
		private bool method_p1;
	}
}
