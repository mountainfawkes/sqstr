import Links from './Links'
/* eslint-disable max-len */

export default ({ estimate }) => {
  const co2Emissions = estimate.data.attributes.carbon_Mt
  const upco2Price = estimate.price
  const fullOffset = co2Emissions * upco2Price
  const threeOffset = (co2Emissions * upco2Price) * 0.75
  const halfOffset = (co2Emissions * upco2Price) * 0.5
  const quarterOffset = (co2Emissions * upco2Price) * 0.25

  return (
    <div>
      <h2>Your activity will emit {estimate.data.attributes.carbon_Mt} metric tonnes of carbon.</h2>
      <p>The current price of <a href='https://universalcarbon.com/'>UPCO2</a> is {estimate.price}.</p>
      <p>At that price, expect the following levels of carbon investment to offset your activity:</p>
      <table>
        <tr>
          <th>Offset Level</th>
          <th>Investment</th>
        </tr>
        <tr>
          <th>Full Offset</th>
          <th>{fullOffset}</th>
        </tr>
        <tr>
          <th>75% Offset</th>
          <th>{threeOffset}</th>
        </tr>
        <tr>
          <th>50% Offset</th>
          <th>{halfOffset}</th>
        </tr>
        <tr>
          <th>25% Offset</th>
          <th>{quarterOffset}</th>
        </tr>
      </table>
      <Links />
    </div>
  )
}
