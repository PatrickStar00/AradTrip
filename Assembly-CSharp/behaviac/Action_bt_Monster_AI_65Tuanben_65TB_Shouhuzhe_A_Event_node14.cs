﻿using System;
using System.Collections.Generic;

namespace behaviac
{
	// Token: 0x02002C4A RID: 11338
	[GeneratedTypeMetaInfo]
	internal class Action_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_A_Event_node14 : Action
	{
		// Token: 0x06014190 RID: 82320 RVA: 0x00608F54 File Offset: 0x00607354
		public Action_bt_Monster_AI_65Tuanben_65TB_Shouhuzhe_A_Event_node14()
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
			item.skillID = 20781;
			item.specialChoice = 0;
			this.method_p0.Add(item);
			this.method_p1 = false;
		}

		// Token: 0x06014191 RID: 82321 RVA: 0x00608FE4 File Offset: 0x006073E4
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			((BTAgent)pAgent).Action_DoAction(ref this.method_p0, this.method_p1);
			return EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400DB57 RID: 56151
		private List<Input> method_p0;

		// Token: 0x0400DB58 RID: 56152
		private bool method_p1;
	}
}
