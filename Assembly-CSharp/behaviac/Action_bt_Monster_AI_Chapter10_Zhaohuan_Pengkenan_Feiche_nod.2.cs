﻿using System;
using System.Collections.Generic;

namespace behaviac
{
	// Token: 0x0200315B RID: 12635
	[GeneratedTypeMetaInfo]
	internal class Action_bt_Monster_AI_Chapter10_Zhaohuan_Pengkenan_Feiche_node1 : Action
	{
		// Token: 0x06014B54 RID: 84820 RVA: 0x0063C89C File Offset: 0x0063AC9C
		public Action_bt_Monster_AI_Chapter10_Zhaohuan_Pengkenan_Feiche_node1()
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
			item.skillID = 20434;
			item.specialChoice = 0;
			this.method_p0.Add(item);
			this.method_p1 = false;
		}

		// Token: 0x06014B55 RID: 84821 RVA: 0x0063C92C File Offset: 0x0063AD2C
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			((BTAgent)pAgent).Action_DoAction(ref this.method_p0, this.method_p1);
			return EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400E4CD RID: 58573
		private List<Input> method_p0;

		// Token: 0x0400E4CE RID: 58574
		private bool method_p1;
	}
}
