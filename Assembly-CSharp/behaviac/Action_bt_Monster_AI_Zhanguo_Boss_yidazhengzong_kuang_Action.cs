﻿using System;
using System.Collections.Generic;

namespace behaviac
{
	// Token: 0x02003EA7 RID: 16039
	[GeneratedTypeMetaInfo]
	internal class Action_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node19 : Action
	{
		// Token: 0x060164CC RID: 91340 RVA: 0x006BE79C File Offset: 0x006BCB9C
		public Action_bt_Monster_AI_Zhanguo_Boss_yidazhengzong_kuang_Action_node19()
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
			item.skillID = 7328;
			item.specialChoice = 0;
			this.method_p0.Add(item);
			this.method_p1 = false;
		}

		// Token: 0x060164CD RID: 91341 RVA: 0x006BE82C File Offset: 0x006BCC2C
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			((BTAgent)pAgent).Action_DoAction(ref this.method_p0, this.method_p1);
			return EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400FCFD RID: 64765
		private List<Input> method_p0;

		// Token: 0x0400FCFE RID: 64766
		private bool method_p1;
	}
}
