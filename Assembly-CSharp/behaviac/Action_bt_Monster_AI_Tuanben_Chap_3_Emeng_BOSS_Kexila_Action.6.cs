﻿using System;
using System.Collections.Generic;

namespace behaviac
{
	// Token: 0x0200384D RID: 14413
	[GeneratedTypeMetaInfo]
	internal class Action_bt_Monster_AI_Tuanben_Chap_3_Emeng_BOSS_Kexila_Action_node29 : Action
	{
		// Token: 0x06015880 RID: 88192 RVA: 0x0067F4E8 File Offset: 0x0067D8E8
		public Action_bt_Monster_AI_Tuanben_Chap_3_Emeng_BOSS_Kexila_Action_node29()
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
			item.skillID = 21214;
			item.specialChoice = 0;
			this.method_p0.Add(item);
			this.method_p1 = false;
		}

		// Token: 0x06015881 RID: 88193 RVA: 0x0067F578 File Offset: 0x0067D978
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			((BTAgent)pAgent).Action_DoAction(ref this.method_p0, this.method_p1);
			return EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400F23A RID: 62010
		private List<Input> method_p0;

		// Token: 0x0400F23B RID: 62011
		private bool method_p1;
	}
}
