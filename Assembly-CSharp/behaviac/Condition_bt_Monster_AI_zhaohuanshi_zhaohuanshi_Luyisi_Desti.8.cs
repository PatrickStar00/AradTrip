﻿using System;

namespace behaviac
{
	// Token: 0x02003FE7 RID: 16359
	[GeneratedTypeMetaInfo]
	internal class Condition_bt_Monster_AI_zhaohuanshi_zhaohuanshi_Luyisi_DestinationSelect_node17 : Condition
	{
		// Token: 0x06016735 RID: 91957 RVA: 0x006CB183 File Offset: 0x006C9583
		public Condition_bt_Monster_AI_zhaohuanshi_zhaohuanshi_Luyisi_DestinationSelect_node17()
		{
			this.opl_p0 = 7000;
			this.opl_p1 = 7000;
			this.opl_p2 = 7000;
			this.opl_p3 = 7000;
		}

		// Token: 0x06016736 RID: 91958 RVA: 0x006CB1B8 File Offset: 0x006C95B8
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			bool flag = ((BTAgent)pAgent).Condition_IsTargetInAttackArea(this.opl_p0, this.opl_p1, this.opl_p2, this.opl_p3);
			bool flag2 = true;
			bool flag3 = flag == flag2;
			return (!flag3) ? EBTStatus.BT_FAILURE : EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400FF86 RID: 65414
		private int opl_p0;

		// Token: 0x0400FF87 RID: 65415
		private int opl_p1;

		// Token: 0x0400FF88 RID: 65416
		private int opl_p2;

		// Token: 0x0400FF89 RID: 65417
		private int opl_p3;
	}
}
