﻿using System;
using System.Collections.Generic;

namespace behaviac
{
	// Token: 0x02003A63 RID: 14947
	[GeneratedTypeMetaInfo]
	internal class Action_bt_Monster_AI_Tuanben_KexilaXianshi_Boss_ACTION_node32 : Action
	{
		// Token: 0x06015C8F RID: 89231 RVA: 0x0069432C File Offset: 0x0069272C
		public Action_bt_Monster_AI_Tuanben_KexilaXianshi_Boss_ACTION_node32()
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
			item.skillID = 21062;
			item.specialChoice = 0;
			this.method_p0.Add(item);
			this.method_p1 = false;
		}

		// Token: 0x06015C90 RID: 89232 RVA: 0x006943BC File Offset: 0x006927BC
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			((BTAgent)pAgent).Action_DoAction(ref this.method_p0, this.method_p1);
			return EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400F5BF RID: 62911
		private List<Input> method_p0;

		// Token: 0x0400F5C0 RID: 62912
		private bool method_p1;
	}
}
