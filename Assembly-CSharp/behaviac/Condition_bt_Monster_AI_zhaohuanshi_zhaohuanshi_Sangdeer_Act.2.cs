﻿using System;

namespace behaviac
{
	// Token: 0x02003FEB RID: 16363
	[GeneratedTypeMetaInfo]
	internal class Condition_bt_Monster_AI_zhaohuanshi_zhaohuanshi_Sangdeer_Action_node5 : Condition
	{
		// Token: 0x0601673C RID: 91964 RVA: 0x006CB6CF File Offset: 0x006C9ACF
		public Condition_bt_Monster_AI_zhaohuanshi_zhaohuanshi_Sangdeer_Action_node5()
		{
			this.opl_p0 = 2000;
			this.opl_p1 = 1500;
			this.opl_p2 = 1500;
			this.opl_p3 = 1500;
		}

		// Token: 0x0601673D RID: 91965 RVA: 0x006CB704 File Offset: 0x006C9B04
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			bool flag = ((BTAgent)pAgent).Condition_IsTargetInAttackArea(this.opl_p0, this.opl_p1, this.opl_p2, this.opl_p3);
			bool flag2 = true;
			bool flag3 = flag == flag2;
			return (!flag3) ? EBTStatus.BT_FAILURE : EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400FF8C RID: 65420
		private int opl_p0;

		// Token: 0x0400FF8D RID: 65421
		private int opl_p1;

		// Token: 0x0400FF8E RID: 65422
		private int opl_p2;

		// Token: 0x0400FF8F RID: 65423
		private int opl_p3;
	}
}
