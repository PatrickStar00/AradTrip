﻿using System;
using System.Collections.Generic;

namespace behaviac
{
	// Token: 0x020024F0 RID: 9456
	[GeneratedTypeMetaInfo]
	internal class Action_bt_AutoFight_AutoFight_Gungirl_Manyou_Action_node66 : Action
	{
		// Token: 0x0601332A RID: 78634 RVA: 0x005B320C File Offset: 0x005B160C
		public Action_bt_AutoFight_AutoFight_Gungirl_Manyou_Action_node66()
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
			item.skillID = 2508;
			item.specialChoice = 0;
			this.method_p0.Add(item);
			this.method_p1 = false;
		}

		// Token: 0x0601332B RID: 78635 RVA: 0x005B329C File Offset: 0x005B169C
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			((BTAgent)pAgent).Action_DoAction(ref this.method_p0, this.method_p1);
			return EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400CD4A RID: 52554
		private List<Input> method_p0;

		// Token: 0x0400CD4B RID: 52555
		private bool method_p1;
	}
}
