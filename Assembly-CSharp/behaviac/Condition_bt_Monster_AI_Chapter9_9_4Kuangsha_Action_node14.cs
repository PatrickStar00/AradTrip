﻿using System;

namespace behaviac
{
	// Token: 0x02003181 RID: 12673
	[GeneratedTypeMetaInfo]
	internal class Condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node14 : Condition
	{
		// Token: 0x06014B99 RID: 84889 RVA: 0x0063D7CE File Offset: 0x0063BBCE
		public Condition_bt_Monster_AI_Chapter9_9_4Kuangsha_Action_node14()
		{
			this.opl_p0 = BE_Target.Self;
			this.opl_p1 = BE_Equal.Equal;
			this.opl_p2 = 570253;
		}

		// Token: 0x06014B9A RID: 84890 RVA: 0x0063D7F0 File Offset: 0x0063BBF0
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			bool flag = ((BTAgent)pAgent).Condition_CheckHasBuff(this.opl_p0, this.opl_p1, this.opl_p2);
			bool flag2 = true;
			bool flag3 = flag == flag2;
			return (!flag3) ? EBTStatus.BT_FAILURE : EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400E504 RID: 58628
		private BE_Target opl_p0;

		// Token: 0x0400E505 RID: 58629
		private BE_Equal opl_p1;

		// Token: 0x0400E506 RID: 58630
		private int opl_p2;
	}
}
