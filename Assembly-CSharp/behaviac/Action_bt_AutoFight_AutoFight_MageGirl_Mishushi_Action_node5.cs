﻿using System;
using System.Collections.Generic;

namespace behaviac
{
	// Token: 0x020026C0 RID: 9920
	[GeneratedTypeMetaInfo]
	internal class Action_bt_AutoFight_AutoFight_MageGirl_Mishushi_Action_node57 : Action
	{
		// Token: 0x060136C3 RID: 79555 RVA: 0x005C8CDC File Offset: 0x005C70DC
		public Action_bt_AutoFight_AutoFight_MageGirl_Mishushi_Action_node57()
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
			item.skillID = 2203;
			item.specialChoice = 0;
			this.method_p0.Add(item);
			this.method_p1 = false;
		}

		// Token: 0x060136C4 RID: 79556 RVA: 0x005C8D6C File Offset: 0x005C716C
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			((BTAgent)pAgent).Action_DoAction(ref this.method_p0, this.method_p1);
			return EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400D119 RID: 53529
		private List<Input> method_p0;

		// Token: 0x0400D11A RID: 53530
		private bool method_p1;
	}
}
