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

  const contentStyles = {
    maxWidth: `45vw`,
    margin: `auto`,
    marginTop: `30px`,
    padding: `10px`,
    justifyContent: `center`,
    alignItems: `center`,
    backgroundColor: `#0A090C`,
  }

  // const inputStyles = {
  //   display: `block`,
  //   margin: `5px`,
  // }

  return (
    <div style={contentStyles}>
      <div style={{
        backgroundColor: `#131217`,
        color: `#F5F5F5`,
        padding: `15px`,
        fontFamily: `'Montserrat', sans-serif`,
      }}
      >
        <p>Your activity will emit the following:</p>
        <div>
          <table style={{ marginLeft: `auto`,
            marginRight: `auto`,
            textAlign: `center`,
            width: `100%` }}
          >
            <tbody style={{ textAlign: `left` }}>
              <tr style={{ fontWeight: `bold` }}>
                <th>Emissions</th>
                <th>Unit</th>
                <th>Offset Level</th>
                <th>Investment</th>
              </tr>
              <tr>
                <td>{co2G}</td>
                <td>Grams</td>
                <td>Full Offset</td>
                <td>{fullOffset}</td>
              </tr>
              <tr>
                <td>{co2Lb}</td>
                <td>Pounds</td>
                <td>75% Offset</td>
                <td>{threeOffset}</td>
              </tr>
              <tr>
                <td>{co2Kg}</td>
                <td>Kilograms</td>
                <td>50% Offset</td>
                <td>{halfOffset}</td>
              </tr>
              <tr>
                <td>{co2Tons}</td>
                <td>Metric Tons</td>
                <td>25% Offset</td>
                <td>{quarterOffset}</td>
              </tr>
            </tbody>
          </table>
        </div>

        <p>The current price of <a
          href='https://universalcarbon.com/'
          style={{ color: `#EDC9AF`,
            textShadow: `1px 1px 10px #EDC9AF`,
            textDecoration: `none` }}
        >UPCO2</a> is {parseFloat(upco2Price).toLocaleString(`us-EN`, { style: `currency`, currency: `USD` })}.</p>

        <Links />
      </div>
    </div>
  )
}
