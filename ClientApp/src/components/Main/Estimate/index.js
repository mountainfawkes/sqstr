import Links from './Links'
/* eslint-disable max-len */

export default ({ estimate }) => {
  const co2G = estimate.data.attributes.carbon_G
  const co2Lb = estimate.data.attributes.carbon_Lb
  const co2Kg = estimate.data.attributes.carbon_Kg
  const co2Tons = co2G / 1000000
  const upco2Price = (estimate.price).toLocaleString(`us-EN`, { style: `currency`, currency: `USD` })
  const fullOffset = (co2Tons * upco2Price).toLocaleString(`us-EN`, { style: `currency`, currency: `USD` })
  const threeOffset = ((co2Tons * upco2Price) * 0.75).toLocaleString(`us-EN`, { style: `currency`, currency: `USD` })
  const halfOffset = ((co2Tons * upco2Price) * 0.5).toLocaleString(`us-EN`, { style: `currency`, currency: `USD` })
  const quarterOffset = ((co2Tons * upco2Price) * 0.25).toLocaleString(`us-EN`, { style: `currency`, currency: `USD` })

  return (
    <div>
      <h2>Your activity will emit the following:
        <table>
          <tr>
            <th>Carbon Emissions</th>
            <th>Unit</th>
          </tr>
          <tr>
            <th>{co2G}</th>
            <th>Grams</th>
          </tr>
          <tr>
            <th>{co2Lb}</th>
            <th>Pounds</th>
          </tr>
          <tr>
            <th>{co2Kg}</th>
            <th>Kilograms</th>
          </tr>
          <tr>
            <th>{co2Tons}</th>
            <th>Metric Tons</th>
          </tr>
        </table>

        {co2Tons} metric tonnes of carbon.</h2>
      <p>The current price of <a href='https://universalcarbon.com/'>UPCO2</a> is {parseFloat(upco2Price).toLocaleString(`us-EN`, { style: `currency`, currency: `USD` })}.</p>
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
