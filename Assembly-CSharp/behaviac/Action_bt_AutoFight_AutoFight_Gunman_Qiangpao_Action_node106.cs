﻿using System;
using System.Collections.Generic;

namespace behaviac
{
	// Token: 0x0200264C RID: 9804
	[GeneratedTypeMetaInfo]
	internal class Action_bt_AutoFight_AutoFight_Gunman_Qiangpao_Action_node106 : Action
	{
		// Token: 0x060135DD RID: 79325 RVA: 0x005C3AEC File Offset: 0x005C1EEC
		public Action_bt_AutoFight_AutoFight_Gunman_Qiangpao_Action_node106()
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
			item.skillID = 1203;
			item.specialChoice = 0;
			this.method_p0.Add(item);
			this.method_p1 = false;
		}

		// Token: 0x060135DE RID: 79326 RVA: 0x005C3B7C File Offset: 0x005C1F7C
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			((BTAgent)pAgent).Action_DoAction(ref this.method_p0, this.method_p1);
			return EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400D02C RID: 53292
		private List<Input> method_p0;

		// Token: 0x0400D02D RID: 53293
		private bool method_p1;
	}
}
