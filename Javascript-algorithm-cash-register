function checkCashRegister(price, cash, cid) {
  let balance=cash-price;
  let total=0
  let change = JSON.parse(JSON.stringify(cid));//deep copy
  for(let obj of change)
    obj[1]=0.0
  for(let object of cid)
    {total+=object[1];}
  if(total<balance)
  {  console.log('not enough bal')
    return {status: "INSUFFICIENT_FUNDS", change: []}}
  if(total==balance)
  {  console.log('spot-on')
    return {status: "CLOSED", change: cid}}
  //return change;
  if(total>balance){let accum=0.0;let i=0;let j=0;
    //while(accum <balance || j<1000){i=0
      //for(let i=cid.length-1;i>=0;i--){
       if(cid[8][1]>0){ 
        if(balance>=100&&cid[8][1]>=100 && accum==0)
        {accum+=100;change[8][1]+=100;cid[8][1]-=100;}}
        //let i=0
      while(i<Math.round(balance/20)){  //round(balance/20) to be more precise
       if(cid[7][1]>0){
        if(balance>=20 && cid[7][1]>=20 && balance-accum>=20)
        {accum+=20;change[7][1]+=20;cid[7][1]-=20}};i++
      }; i=0
      while(i<Math.round(balance/10)){   //round(balance/10)
        if(cid[6][1]>0){
        if(balance>=10 && cid[6][1]>=10 && balance-accum>=10)
        {accum+=10;change[6][1]+=10;cid[6][1]-=10}};i++
      }; i=0
      while(i<Math.round(balance/5)){
        if(cid[5][1]>0){
        if(balance>=5 && cid[5][1]>=5 && balance-accum>=5)
        {accum+=5;change[5][1]+=5;cid[5][1]-=5}};i++
      }; i=0
      while(i<Math.round(balance/1)){
        if(cid[4][1]>0){
        if(balance>=1 && cid[4][1]>=1 && balance-accum>=1)
        {accum+=1;change[4][1]+=1;cid[4][1]-=1}};i++
      };i=0
      while(i<Math.round(balance/0.25)){
        if(cid[3][1]>0){
        if(balance>=0.25 && cid[3][1]>=0.25 && balance-accum>=0.25)
        {accum+=0.25;change[3][1]+=0.25;cid[3][1]-=0.25}};i++
      };i=0
      while(i<Math.round(balance/0.1)){
        if(cid[2][1]>0){
        if(balance>=0.1 && cid[2][1]>=0.1 && balance-accum>=0.1)
        {accum+=0.1;change[2][1]+=0.1;cid[2][1]-=0.1}};i++
      };i=0
      while(i<Math.round(balance/0.05)){
        if(cid[1][1]>0){
        if(balance>=0.05 && cid[1][1]>=0.05 && balance-accum>=0.05)
        {accum+=0.05;change[1][1]+=0.05;cid[1][1]-=0.05}};i++
      };i=0
      while(i<Math.round(balance/0.01)){
        if(cid[0][1]>0){
        if(balance>=0.01 && cid[0][1]>=0.01 && (balance-accum).toFixed(2)>=0.01)
        {accum+=0.01;change[0][1]+=0.01;cid[0][1]-=0.01;
        //accum=accum.toFixed(2)
        }};i++
      }
      //}  NOTE: .toFixed() converts to string
      accum=accum.toFixed(2)
      accum=parseFloat(accum)
       let tot=0
        for(let object of change)
    {tot+=object[1];};console.log(typeof accum+' '+accum)
    //}//endw
       
    if(accum==balance)
     {let k=0; ;for(let obj=0;obj<change.length*9;obj++){
       if(change[k][1]==0)
       change.splice(k,1)
       else
       k++   
     };
     console.log("open")
       return {status: "OPEN", change: change}}
    if(accum>balance ){console.log('insufficient funds money')
     return {status: "INSUFFICIENT_FUNDS", change: []}}
  }
}
checkCashRegister(3.26, 100, [["PENNY", 1.01], ["NICKEL", 2.05], ["DIME", 3.1], ["QUARTER", 4.25], ["ONE", 90], ["FIVE", 55], ["TEN", 20], ["TWENTY", 60], ["ONE HUNDRED", 100]])
/*checkCashRegister(19.5, 20, [["PENNY", 1.01], ["NICKEL", 2.05], ["DIME", 3.1], ["QUARTER", 4.25], ["ONE", 90], ["FIVE", 55], ["TEN", 20], ["TWENTY", 60], ["ONE HUNDRED", 100]]);*/
